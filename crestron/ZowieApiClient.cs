using System;
using System.Text;
using Crestron.SimplSharp.Net.Https;
using Newtonsoft.Json;

namespace ZowieCrestron
{
    public class ZowieApiClient : IDisposable
    {
        private readonly ZowieApiConfig _config;

        private enum OptionLocation { Query, Header }

        public ZowieApiClient(ZowieApiConfig config)
        {
            if (config == null)
                throw new ArgumentNullException("config");
            _config = config;
        }

        public TResponse PostStreamplay<TRequest, TResponse>(TRequest request)
            where TRequest : IZowieRequest
        {
            return Post<TRequest, TResponse>("/streamplay", request.Option, OptionLocation.Query, request);
        }

        public TResponse PostRecord<TRequest, TResponse>(TRequest request)
            where TRequest : IZowieRequest
        {
            return Post<TRequest, TResponse>("/record", request.Option, OptionLocation.Query, request);
        }

        private TResponse Post<TRequest, TResponse>(
            string path, string option, OptionLocation optionLocation, TRequest body)
        {
            string url = BuildUrl(path, option, optionLocation);
            string json = JsonConvert.SerializeObject(body);

            //Crestron.SimplSharp.CrestronConsole.PrintLine("[ZowieApiClient] POST {0}", url);
            //Crestron.SimplSharp.CrestronConsole.PrintLine("[ZowieApiClient] Request : {0}", json);

            HttpsClient client = new HttpsClient();
            client.HostVerification = false;
            client.PeerVerification = false;
            client.KeepAlive = false;

            HttpsClientRequest httpsRequest = new HttpsClientRequest();
            httpsRequest.RequestType = RequestType.Post;
            httpsRequest.Url = new Crestron.SimplSharp.Net.Http.UrlParser(url);
            httpsRequest.Header.SetHeaderValue("Content-Type", "application/json");
            if (optionLocation == OptionLocation.Header)
                httpsRequest.Header.SetHeaderValue("option", option);
            httpsRequest.ContentString = json;

            HttpsClientResponse response = client.Dispatch(httpsRequest);

            //Crestron.SimplSharp.CrestronConsole.PrintLine("[ZowieApiClient] Response: {0} {1}", response.Code, response.ContentString);

            if (response.Code < 200 || response.Code >= 300)
                throw new Exception("HTTP error: " + response.Code);

            return JsonConvert.DeserializeObject<TResponse>(response.ContentString);
        }

        private string BuildUrl(string path, string option, OptionLocation optionLocation)
        {
            StringBuilder sb = new StringBuilder(_config.BaseUrl);
            sb.Append(path).Append('?');
            sb.Append("login_check_flag=").Append(Uri.EscapeDataString(_config.LoginCheckFlag));
            if (optionLocation == OptionLocation.Query)
                sb.Append("&option=").Append(Uri.EscapeDataString(option));
            return sb.ToString();
        }

        public void Dispose()
        {
        }
    }
}

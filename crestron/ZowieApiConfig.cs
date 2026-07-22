using System;

namespace ZowieCrestron
{
    public class ZowieApiConfig
    {
        public string BaseUrl { get; private set; }
        public string LoginCheckFlag { get; private set; }

        public ZowieApiConfig(string baseUrl, string loginCheckFlag)
        {
            if (string.IsNullOrEmpty(baseUrl))
                throw new ArgumentNullException("baseUrl");
            BaseUrl = baseUrl.TrimEnd('/');
            LoginCheckFlag = loginCheckFlag ?? string.Empty;
        }
    }
}

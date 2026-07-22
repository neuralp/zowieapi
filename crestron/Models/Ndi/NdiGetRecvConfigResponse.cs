using Newtonsoft.Json;

namespace ZowieCrestron.Models.Ndi
{
    public class NdiGetRecvConfigResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("rsp")]
        public string Rsp { get; set; }

        [JsonProperty("data")]
        public NdiRecvConfigData Data { get; set; }

        public bool IsSuccess { get { return Status == "00000"; } }

        public class NdiRecvConfigData
        {
            [JsonProperty("groups")]
            public string Groups { get; set; }
        }
    }
}

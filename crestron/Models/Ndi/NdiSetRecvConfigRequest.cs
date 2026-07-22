using Newtonsoft.Json;

namespace ZowieCrestron.Models.Ndi
{
    public class NdiSetRecvConfigRequest : IZowieRequest
    {
        [JsonIgnore]
        public string Option { get { return "setinfo"; } }

        [JsonProperty("group")]
        public string Group { get { return "streamplay_ndi"; } }

        [JsonProperty("opt")]
        public string Opt { get { return "ndi_set_recv_config"; } }

        [JsonProperty("data")]
        public NdiSetRecvConfigData Data { get; set; }

        public class NdiSetRecvConfigData
        {
            [JsonProperty("groups")]
            public string Groups { get; set; }
        }
    }
}

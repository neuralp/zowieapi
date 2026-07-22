using Newtonsoft.Json;

namespace ZowieCrestron.Models.Ndi
{
    public class NdiGetRecvConfigRequest : IZowieRequest
    {
        [JsonIgnore]
        public string Option { get { return "getinfo"; } }

        [JsonProperty("group")]
        public string Group { get { return "streamplay_ndi"; } }

        [JsonProperty("opt")]
        public string Opt { get { return "ndi_get_recv_config"; } }
    }
}

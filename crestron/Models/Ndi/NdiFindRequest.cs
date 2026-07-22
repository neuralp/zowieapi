using Newtonsoft.Json;

namespace ZowieCrestron.Models.Ndi
{
    public class NdiFindRequest : IZowieRequest
    {
        [JsonIgnore]
        public string Option { get { return "setinfo"; } }

        [JsonProperty("group")]
        public string Group { get { return "streamplay_ndi"; } }

        [JsonProperty("opt")]
        public string Opt { get { return "ndi_find"; } }
    }
}

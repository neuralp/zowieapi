using Newtonsoft.Json;

namespace ZowieCrestron.Models.Ndi
{
    public class NdiRecvRequest : IZowieRequest
    {
        [JsonIgnore]
        public string Option { get { return "setinfo"; } }

        [JsonProperty("group")]
        public string Group { get { return "streamplay_ndi"; } }

        [JsonProperty("opt")]
        public string Opt { get { return "ndi_recv"; } }

        [JsonProperty("data")]
        public NdiRecvData Data { get; set; }

        public class NdiRecvData
        {
            [JsonProperty("ndi_name")]
            public string NdiName { get; set; }
        }
    }
}

using Newtonsoft.Json;

namespace ZowieCrestron.Models.Decoding
{
    public class StreamplayGetAllRequest : IZowieRequest
    {
        [JsonIgnore]
        public string Option { get { return "getinfo"; } }

        [JsonProperty("group")]
        public string Group { get { return "streamplay"; } }

        [JsonProperty("opt")]
        public string Opt { get { return "streamplay_get_all"; } }
    }
}

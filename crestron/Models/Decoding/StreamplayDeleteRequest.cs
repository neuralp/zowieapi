using Newtonsoft.Json;

namespace ZowieCrestron.Models.Decoding
{
    public class StreamplayDeleteRequest : IZowieRequest
    {
        [JsonIgnore]
        public string Option { get { return "setinfo"; } }

        [JsonProperty("group")]
        public string Group { get { return "streamplay"; } }

        [JsonProperty("opt")]
        public string Opt { get { return "streamplay_del"; } }

        [JsonProperty("data")]
        public StreamplayDeleteData Data { get; set; }

        public class StreamplayDeleteData
        {
            [JsonProperty("index")]
            public int Index { get; set; }
        }
    }
}

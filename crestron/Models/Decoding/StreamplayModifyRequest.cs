using Newtonsoft.Json;

namespace ZowieCrestron.Models.Decoding
{
    public class StreamplayModifyRequest : IZowieRequest
    {
        [JsonIgnore]
        public string Option { get { return "setinfo"; } }

        [JsonProperty("group")]
        public string Group { get { return "streamplay"; } }

        [JsonProperty("opt")]
        public string Opt { get { return "streamplay_modify"; } }

        [JsonProperty("data")]
        public StreamplayModifyData Data { get; set; }

        public class StreamplayModifyData
        {
            [JsonProperty("index")]
            public int Index { get; set; }

            [JsonProperty("switch", NullValueHandling = NullValueHandling.Ignore)]
            public int? Switch { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("streamtype", NullValueHandling = NullValueHandling.Ignore)]
            public int? StreamType { get; set; }

            [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
            public string Url { get; set; }
        }
    }
}

using Newtonsoft.Json;

namespace ZowieCrestron.Models.Decoding
{
    public class StreamplayAddRequest : IZowieRequest
    {
        [JsonIgnore]
        public string Option { get { return "setinfo"; } }

        [JsonProperty("group")]
        public string Group { get { return "streamplay"; } }

        [JsonProperty("opt")]
        public string Opt { get { return "streamplay_add"; } }

        [JsonProperty("data")]
        public StreamplayAddData Data { get; set; }

        public class StreamplayAddData
        {
            [JsonProperty("switch")]
            public int Switch { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("streamtype")]
            public int StreamType { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }
        }
    }
}

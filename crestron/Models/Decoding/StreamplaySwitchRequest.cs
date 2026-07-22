using Newtonsoft.Json;

namespace ZowieCrestron.Models.Decoding
{
    public class StreamplaySwitchRequest : IZowieRequest
    {
        [JsonIgnore]
        public string Option { get { return "setinfo"; } }

        [JsonProperty("group")]
        public string Group { get { return "streamplay"; } }

        [JsonProperty("opt")]
        public string Opt { get { return "streamplay_switch"; } }

        [JsonProperty("data")]
        public StreamplaySwitchData Data { get; set; }

        public class StreamplaySwitchData
        {
            [JsonProperty("switch")]
            public int Switch { get; set; }

            [JsonProperty("index")]
            public int Index { get; set; }
        }
    }
}

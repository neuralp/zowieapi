using Newtonsoft.Json;

namespace ZowieCrestron.Models.Recording
{
    public class SetTaskEnableRequest : IZowieRequest
    {
        [JsonIgnore]
        public string Option { get { return "setinfo"; } }

        [JsonProperty("group")]
        public string Group { get { return "record"; } }

        [JsonProperty("opt")]
        public string Opt { get { return "set_task_enable"; } }

        [JsonProperty("data")]
        public SetTaskEnableData Data { get; set; }

        public class SetTaskEnableData
        {
            [JsonProperty("index")]
            public string Index { get; set; }

            [JsonProperty("enable")]
            public int Enable { get; set; }
        }
    }
}

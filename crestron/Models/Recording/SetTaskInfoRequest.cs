using Newtonsoft.Json;

namespace ZowieCrestron.Models.Recording
{
    public class SetTaskInfoRequest : IZowieRequest
    {
        [JsonIgnore]
        public string Option { get { return "setinfo"; } }

        [JsonProperty("group")]
        public string Group { get { return "record"; } }

        [JsonProperty("opt")]
        public string Opt { get { return "set_task_info"; } }

        [JsonProperty("data")]
        public SetTaskInfoData Data { get; set; }

        public class SetTaskInfoData
        {
            [JsonProperty("index")]
            public string Index { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("file_name_prefix", NullValueHandling = NullValueHandling.Ignore)]
            public string FileNamePrefix { get; set; }

            [JsonProperty("record_format", NullValueHandling = NullValueHandling.Ignore)]
            public int? RecordFormat { get; set; }

            [JsonProperty("record_mode", NullValueHandling = NullValueHandling.Ignore)]
            public int? RecordMode { get; set; }

            [JsonProperty("record_loop_mode", NullValueHandling = NullValueHandling.Ignore)]
            public int? RecordLoopMode { get; set; }

            [JsonProperty("limit_type", NullValueHandling = NullValueHandling.Ignore)]
            public int? LimitType { get; set; }

            [JsonProperty("size_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int? SizeLimit { get; set; }

            [JsonProperty("time_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int? TimeLimit { get; set; }

            [JsonProperty("storage_id", NullValueHandling = NullValueHandling.Ignore)]
            public int? StorageId { get; set; }

            [JsonProperty("stream_id", NullValueHandling = NullValueHandling.Ignore)]
            public int? StreamId { get; set; }
        }
    }
}

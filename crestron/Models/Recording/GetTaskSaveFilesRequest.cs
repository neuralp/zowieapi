using Newtonsoft.Json;

namespace ZowieCrestron.Models.Recording
{
    public class GetTaskSaveFilesRequest : IZowieRequest
    {
        [JsonIgnore]
        public string Option { get { return "getinfo"; } }

        [JsonProperty("group")]
        public string Group { get { return "record"; } }

        [JsonProperty("opt")]
        public string Opt { get { return "get_task_savefiles_page"; } }

        [JsonProperty("data")]
        public GetTaskSaveFilesData Data { get; set; }

        public class GetTaskSaveFilesData
        {
            [JsonProperty("index")]
            public string Index { get; set; }

            [JsonProperty("control", NullValueHandling = NullValueHandling.Ignore)]
            public PageControl Control { get; set; }

            [JsonProperty("case_num", NullValueHandling = NullValueHandling.Ignore)]
            public int? CaseNum { get; set; }

            public class PageControl
            {
                [JsonProperty("currentPage")]
                public int CurrentPage { get; set; }

                [JsonProperty("default_Record_Num")]
                public int DefaultRecordNum { get; set; }
            }
        }
    }
}

using Newtonsoft.Json;

namespace ZowieCrestron.Models.Recording
{
    public class PaginationControl
    {
        [JsonProperty("firstPage")]
        public int FirstPage { get; set; }

        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        [JsonProperty("lastPage")]
        public int LastPage { get; set; }

        [JsonProperty("default_Record_Num")]
        public int DefaultRecordNum { get; set; }

        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("frontPage")]
        public int FrontPage { get; set; }

        [JsonProperty("nextPage")]
        public int NextPage { get; set; }
    }
}

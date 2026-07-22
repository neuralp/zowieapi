using Newtonsoft.Json;

namespace ZowieCrestron.Models.Recording
{
    public class RecordingFile
    {
        [JsonProperty("task_id")]
        public string TaskId { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("case_num")]
        public int CaseNum { get; set; }

        [JsonProperty("start_time_obj")]
        public TimeObject StartTimeObj { get; set; }

        [JsonProperty("end_time_obj")]
        public TimeObject EndTimeObj { get; set; }
    }
}

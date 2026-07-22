using System.Collections.Generic;
using Newtonsoft.Json;

namespace ZowieCrestron.Models.Recording
{
    public class GetTaskListResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("rsp")]
        public string Rsp { get; set; }

        [JsonProperty("data")]
        public List<RecordingTask> Data { get; set; }

        public bool IsSuccess { get { return Status == "00000"; } }
    }
}

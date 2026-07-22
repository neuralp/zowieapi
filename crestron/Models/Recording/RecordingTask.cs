using Newtonsoft.Json;

namespace ZowieCrestron.Models.Recording
{
    public class RecordingTask
    {
        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("file_name_prefix")]
        public string FileNamePrefix { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("record_format")]
        public int RecordFormat { get; set; }

        [JsonProperty("record_mode")]
        public int RecordMode { get; set; }

        [JsonProperty("record_loop_mode")]
        public int RecordLoopMode { get; set; }

        [JsonProperty("limit_type")]
        public int LimitType { get; set; }

        [JsonProperty("size_limit")]
        public int SizeLimit { get; set; }

        [JsonProperty("time_limit")]
        public int TimeLimit { get; set; }

        [JsonProperty("enable")]
        public int Enable { get; set; }

        [JsonProperty("storage_id")]
        public int StorageId { get; set; }

        [JsonProperty("stream_id")]
        public int StreamId { get; set; }

        [JsonProperty("audio_stream_id")]
        public int AudioStreamId { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("storageInfo")]
        public StorageDeviceInfo StorageInfo { get; set; }

        [JsonProperty("curr_file_name")]
        public string CurrentFileName { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        public bool IsRecording { get { return Status == 1; } }
        public bool IsPaused { get { return Status == 2; } }
    }
}

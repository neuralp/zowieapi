using System.Collections.Generic;
using Newtonsoft.Json;

namespace ZowieCrestron.Models.Recording
{
    public class GetTaskSaveFilesResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("rsp")]
        public string Rsp { get; set; }

        [JsonProperty("data")]
        public SaveFilesData Data { get; set; }

        public bool IsSuccess { get { return Status == "00000"; } }

        public class SaveFilesData
        {
            [JsonProperty("storage_info")]
            public StorageDeviceInfo StorageInfo { get; set; }

            [JsonProperty("control")]
            public PaginationControl Control { get; set; }

            [JsonProperty("storage_files_size")]
            public int StorageFilesSize { get; set; }

            [JsonProperty("storage_files")]
            public List<RecordingFile> StorageFiles { get; set; }
        }
    }
}

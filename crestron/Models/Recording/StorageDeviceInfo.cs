using Newtonsoft.Json;

namespace ZowieCrestron.Models.Recording
{
    public class StorageDeviceInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("mount_path")]
        public string MountPath { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("totalspace")]
        public int TotalSpace { get; set; }

        [JsonProperty("freespace")]
        public int FreeSpace { get; set; }

        [JsonProperty("usagespace")]
        public int UsageSpace { get; set; }

        [JsonProperty("file_system")]
        public int FileSystem { get; set; }

        [JsonProperty("speed_test_status")]
        public int? SpeedTestStatus { get; set; }

        [JsonProperty("write_speed")]
        public double? WriteSpeed { get; set; }

        [JsonProperty("read_speed")]
        public double? ReadSpeed { get; set; }
    }
}

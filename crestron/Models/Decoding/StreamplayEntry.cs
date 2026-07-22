using Newtonsoft.Json;

namespace ZowieCrestron.Models.Decoding
{
    public class StreamplayEntry
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("switch")]
        public int Switch { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("streamtype")]
        public int StreamType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("streamplay_status")]
        public StreamplayStatusCode StreamplayStatus { get; set; }

        [JsonProperty("bandwidth")]
        public int Bandwidth { get; set; }

        [JsonProperty("framerate")]
        public double Framerate { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }
}

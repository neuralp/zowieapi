using Newtonsoft.Json;
using ZowieCrestron.Models.Decoding;

namespace ZowieCrestron.Models.Ndi
{
    public class NdiSourceEntry
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

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

using System.Collections.Generic;
using Newtonsoft.Json;

namespace ZowieCrestron.Models.Decoding
{
    public class StreamplayGetAllResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("rsp")]
        public string Rsp { get; set; }

        [JsonProperty("data")]
        public List<StreamplayEntry> Streamplay { get; set; }

        public bool IsSuccess { get { return Status == "00000"; } }
    }
}

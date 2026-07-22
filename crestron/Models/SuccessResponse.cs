using Newtonsoft.Json;

namespace ZowieCrestron.Models
{
    public class SuccessResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("rsp")]
        public string Rsp { get; set; }

        public bool IsSuccess { get { return Status == "00000"; } }
    }
}

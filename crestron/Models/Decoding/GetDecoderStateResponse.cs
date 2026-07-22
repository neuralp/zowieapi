using Newtonsoft.Json;

namespace ZowieCrestron.Models.Decoding
{
    public class GetDecoderStateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("rsp")]
        public string Rsp { get; set; }

        [JsonProperty("data")]
        public DecoderStateData Data { get; set; }

        public bool IsSuccess { get { return Status == "00000"; } }

        public class DecoderStateData
        {
            [JsonProperty("decoder_state")]
            public int DecoderState { get; set; }

            public bool IsDecoding { get { return DecoderState == 1; } }
        }
    }
}

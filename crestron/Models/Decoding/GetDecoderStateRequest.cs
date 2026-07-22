using Newtonsoft.Json;

namespace ZowieCrestron.Models.Decoding
{
    public class GetDecoderStateRequest : IZowieRequest
    {
        [JsonIgnore]
        public string Option { get { return "getinfo"; } }

        [JsonProperty("group")]
        public string Group { get { return "streamplay"; } }

        [JsonProperty("opt")]
        public string Opt { get { return "get_decoder_state"; } }
    }
}

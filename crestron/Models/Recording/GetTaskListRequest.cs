using Newtonsoft.Json;

namespace ZowieCrestron.Models.Recording
{
    public class GetTaskListRequest : IZowieRequest
    {
        [JsonIgnore]
        public string Option { get { return "getinfo"; } }

        [JsonProperty("group")]
        public string Group { get { return "record"; } }

        [JsonProperty("opt")]
        public string Opt { get { return "get_task_list"; } }
    }
}

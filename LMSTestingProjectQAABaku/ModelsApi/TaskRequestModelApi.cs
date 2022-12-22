using System.Text.Json.Serialization;

namespace LMSTestingProjectQAABaku.ModelsApi
{
    public class TaskRequestModelApi
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("links")]
        public string links { get; set; }

        [JsonPropertyName("isRequired")]
        public bool isRequired { get; set; }

        [JsonPropertyName("groupId")]
        public int groupId { get; set; }
    }
}

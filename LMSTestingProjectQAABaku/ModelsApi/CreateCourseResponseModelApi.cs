using System.Text.Json.Serialization;

namespace LMSTestingProjectQAABaku.ModelsApi
{
    public class CreateCourseResponseModelApi
    {
        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("topics")]
        public List<object> topics { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("isDeleted")]
        public bool isDeleted { get; set; }
    }
}

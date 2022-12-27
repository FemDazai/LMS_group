using System.Text.Json.Serialization;

namespace LMSTestingProjectQAABaku.ModelsApi
{
    public class HomeworkResponseModelApi
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("startDate")]
        public string startDate { get; set; }

        [JsonPropertyName("endDate")]
        public string endDate { get; set; }
    }
}

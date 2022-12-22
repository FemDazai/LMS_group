using System.Text.Json.Serialization;

namespace LMSTestingProjectQAABaku.ModelsApi
{
    public class CreateGroupeModelApi
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("courseId")]
        public int courseId { get; set; }

        [JsonPropertyName("groupStatusId")]
        public string groupStatusId { get; set; }

        [JsonPropertyName("startDate")]
        public string startDate { get; set; }

        [JsonPropertyName("endDate")]
        public string endDate { get; set; }

        [JsonPropertyName("timetable")]
        public string timetable { get; set; }

        [JsonPropertyName("paymentPerMonth")]
        public int paymentPerMonth { get; set; }

        [JsonPropertyName("paymentsCount")]
        public int paymentsCount { get; set; }
    }
}

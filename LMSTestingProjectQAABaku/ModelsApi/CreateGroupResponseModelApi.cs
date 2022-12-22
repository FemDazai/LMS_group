using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku.ModelsApi
{
    public class CreateGroupResponseModelApi
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("course")]
        public Course course { get; set; }

        [JsonPropertyName("groupStatus")]
        public string groupStatus { get; set; }

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

        public class Course
        {
            [JsonPropertyName("id")]
            public int id { get; set; }

            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("isDeleted")]
            public bool isDeleted { get; set; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku.ModelsApi
{
    public class TasksResponseModelApi
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("links")]
        public string links { get; set; }

        [JsonPropertyName("isRequired")]
        public bool isRequired { get; set; }

        [JsonPropertyName("isDeleted")]
        public bool isDeleted { get; set; }
    }
}

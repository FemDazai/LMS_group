using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku.ModelsApi
{
    public class RequestModelApi
    {
        [JsonPropertyName("firstName")]
        public string firstName { get; set; }

        [JsonPropertyName("lastName")]
        public string lastName { get; set; }

        [JsonPropertyName("patronymic")]
        public string patronymic { get; set; }

        [JsonPropertyName("email")]
        public string email { get; set; }

        [JsonPropertyName("username")]
        public string username { get; set; }

        [JsonPropertyName("password")]
        public string password { get; set; }

        [JsonPropertyName("city")]
        public string city { get; set; }

        [JsonPropertyName("birthDate")]
        public string birthDate { get; set; }

        [JsonPropertyName("gitHubAccount")]
        public string gitHubAccount { get; set; }

        [JsonPropertyName("phoneNumber")]
        public string phoneNumber { get; set; }
    }
}

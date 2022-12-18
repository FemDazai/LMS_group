using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku.ModelsApi
{
    public class GetUserByIdApi
    {
        [JsonPropertyName("patronymic")]
        public string patronymic { get; set; }

        [JsonPropertyName("username")]
        public string username { get; set; }

        [JsonPropertyName("registrationDate")]
        public string registrationDate { get; set; }

        [JsonPropertyName("birthDate")]
        public string birthDate { get; set; }

        [JsonPropertyName("gitHubAccount")]
        public object gitHubAccount { get; set; }

        [JsonPropertyName("phoneNumber")]
        public string phoneNumber { get; set; }

        [JsonPropertyName("exileDate")]
        public string exileDate { get; set; }

        [JsonPropertyName("city")]
        public string city { get; set; }

        [JsonPropertyName("groups")]
        public List<object> groups { get; set; }

        [JsonPropertyName("roles")]
        public List<string> roles { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("firstName")]
        public string firstName { get; set; }

        [JsonPropertyName("lastName")]
        public string lastName { get; set; }

        [JsonPropertyName("email")]
        public string email { get; set; }

        [JsonPropertyName("photo")]
        public object photo { get; set; }
    }
}

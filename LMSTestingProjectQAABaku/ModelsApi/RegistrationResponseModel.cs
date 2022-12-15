using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku.ModelsApi
{
    public class RegistrationResponseModel
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("firstName")]
        public string firstName { get; set; }

        [JsonPropertyName("lastName")]
        public string lastName { get; set; }

        [JsonPropertyName("email")]
        public string email { get; set; }

        [JsonPropertyName("photo")]
        public string photo { get; set; }

        [JsonPropertyName("roles")]
        public List<string> roles { get; set; }

        [JsonPropertyName("patronymic")]
        public string patronymic { get; set; }

        [JsonPropertyName("username")]
        public string username { get; set; }

        [JsonPropertyName("registrationDate")]
        public string registrationDate { get; set; }

        [JsonPropertyName("birthDate")]
        public string birthDate { get; set; }

        [JsonPropertyName("gitHubAccount")]
        public string gitHubAccount { get; set; }

        [JsonPropertyName("phoneNumber")]
        public string phoneNumber { get; set; }

        [JsonPropertyName("exileDate")]
        public string exileDate { get; set; }

        [JsonPropertyName("city")]
        public string city { get; set; }

        [JsonPropertyName("groups")]
        public List<Group> groups { get; set; }
    }

    public class Course
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("isDeleted")]
        public bool isDeleted { get; set; }
    }

    public class Group
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
    }
}

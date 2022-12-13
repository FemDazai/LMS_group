using System.Text.Json.Serialization;

namespace LMSTestingProjectQAABaku.Models
{
    public class AuthRequestModelApi
    {
        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}

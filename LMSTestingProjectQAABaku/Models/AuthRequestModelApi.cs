using System.Text.Json.Serialization;

namespace LMSTestingProjectQAABaku.Models
{
    public class AuthRequestModelApi
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}

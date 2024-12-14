using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class TokenModel
    {
        /// <summary>
        /// Access Token.
        /// </summary>
        [JsonProperty(PropertyName = "accessToken", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AccessToken { get; set; }

        /// <summary>
        /// Refresh Token.
        /// </summary>
        [JsonProperty(PropertyName = "refreshToken", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? RefreshToken { get; set; }
    }
}

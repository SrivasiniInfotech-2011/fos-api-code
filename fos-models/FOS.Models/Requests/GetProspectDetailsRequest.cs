using Newtonsoft.Json;

namespace FOS.Models.Requests
{
    public class GetProspectDetailsRequest
    {
        [JsonProperty(PropertyName = "userId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? UserId { get; set; }

        [JsonProperty(PropertyName = "companyId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? CompanyId { get; set; }

        [JsonProperty(PropertyName = "prospectId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? ProspectId { get; set; }

        [JsonProperty(PropertyName = "mobileNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? MobileNumber { get; set; }

        [JsonProperty(PropertyName = "aadharNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AadharNumber { get; set; }

        [JsonProperty(PropertyName = "panNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? PanNumber { get; set; }
    }
}

using Newtonsoft.Json;

namespace FOS.Models.Requests
{
    /// <summary>
    /// Request Model for Getting the Branch Location.
    /// </summary>
    public class BranchLocationRequest
    {
        [JsonProperty(PropertyName = "userId", NullValueHandling = NullValueHandling.Ignore,Required =Required.Default)]
        public int? UserId { get; set; }

        [JsonProperty(PropertyName = "companyId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? CompanyId { get; set; }

        [JsonProperty(PropertyName = "lobId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? LobId { get; set; }

        [JsonProperty(PropertyName = "isActive", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public bool? IsActive { get; set; }
    }
}

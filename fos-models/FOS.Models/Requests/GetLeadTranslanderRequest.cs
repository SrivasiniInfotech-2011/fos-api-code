using Newtonsoft.Json;

namespace FOS.Models.Requests
{
    public class GetLeadTranslanderRequest
    {
        [JsonProperty(PropertyName = "companyId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? CompanyId { get; set; }

        [JsonProperty(PropertyName = "userId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? UserId { get; set; }

        [JsonProperty(PropertyName = "status", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Status { get; set; }

        [JsonProperty(PropertyName = "leadNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LeadNumber { get; set; }

        [JsonProperty(PropertyName = "vehicleNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VehicleNumber { get; set; }

        [JsonProperty(PropertyName = "currentPage", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? CurrentPage { get; set; }

        [JsonProperty(PropertyName = "pageSize", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? PageSize { get; set; }

        [JsonProperty(PropertyName = "searchValue", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? SearchValue { get; set; }
    }
}

using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class LeadProspectDetail
    {
        [JsonProperty(PropertyName = "prospectId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? ProspectId { get; set; }

        [JsonProperty(PropertyName = "prospectName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? ProspectName { get; set; }

        [JsonProperty(PropertyName = "leadType", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LeadType { get; set; }

        [JsonProperty(PropertyName = "leadTypeName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LeadTypeName { get; set; }

        [JsonProperty(PropertyName = "prospectAddress", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? ProspectAddress { get; set; }

        [JsonProperty(PropertyName = "mobileNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? MobileNumber { get; set; }

        [JsonProperty(PropertyName = "vehicleNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VehicleNumber { get; set; }

        [JsonProperty(PropertyName = "aadharNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AadharNumber { get; set; }

        [JsonProperty(PropertyName = "panNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? PanNumber { get; set; }

        [JsonProperty(PropertyName = "locationId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? LocationId { get; set; }

        [JsonProperty(PropertyName = "locationName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LocationName { get; set; }

        [JsonProperty(PropertyName = "prospectTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? ProspectTypeId { get; set; }

        [JsonProperty(PropertyName = "prospectTypeDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? ProspectTypeDescription { get; set; }

        [JsonProperty(PropertyName = "prospectDateOfBirth", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? ProspectDateOfBirth { get; set; }

        [JsonProperty(PropertyName = "prospectDate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? ProspectDate { get; set; }

    }
}

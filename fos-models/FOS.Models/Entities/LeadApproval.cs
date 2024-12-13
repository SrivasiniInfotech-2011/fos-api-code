using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class LeadApproval
    {
        [JsonProperty(PropertyName = "approvedPersonLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)] 
        public int? ApprovedPersonLookupTypeId { get; set; }

        [JsonProperty(PropertyName = "approvedPersonLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? ApprovedPersonLookupValueId { get; set; }

        [JsonProperty(PropertyName = "approvalStatusLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? ApprovalStatusLookupTypeId { get; set; }

        [JsonProperty(PropertyName = "approvalStatusLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? ApprovalStatusLookupValueId { get; set; }

        [JsonProperty(PropertyName = "approvalRemarks", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? ApprovalRemarks { get; set; }

        [JsonProperty(PropertyName = "approvedDate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? ApprovedDate { get; set; }

        [JsonProperty(PropertyName = "approvedBy", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? ApprovedBy { get; set; }

        [JsonProperty(PropertyName = "approvedOn", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? ApprovedOn { get; set; }

        [JsonProperty(PropertyName = "isRevoked", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public bool? IsRevoked { get; set; }

        [JsonProperty(PropertyName = "revokedBy", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? RevokedBy { get; set; }

        [JsonProperty(PropertyName = "revokedOn", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? RevokedOn { get; set; }

        [JsonProperty(PropertyName = "revokedReason", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? RevokedReason { get; set; }

        [JsonProperty(PropertyName = "approvalDetails", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public List<LeadApprovalDetail>? ApprovalDetails { get; set; }
    }
}

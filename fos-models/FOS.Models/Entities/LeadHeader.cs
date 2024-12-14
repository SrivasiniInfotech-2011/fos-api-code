using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class LeadHeader
    {
        [JsonProperty(PropertyName = "leadId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? LeadId { get; set; } = default!;
        [JsonProperty(PropertyName = "prospectId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? ProspectId { get; set; } = default!;

        [JsonProperty(PropertyName = "leadNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)] 
        public string? LeadNumber { get; set; } = default!;
        [JsonProperty(PropertyName = "leadDate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? LeadDate { get; set; }
        [JsonProperty(PropertyName = "leadTypeLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? LeadTypeLookupTypeId { get; set; }
        [JsonProperty(PropertyName = "leadTypeLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? LeadTypeLookupValueId { get; set; }
        [JsonProperty(PropertyName = "financeAmount", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public decimal? FinanceAmount { get; set; }
        [JsonProperty(PropertyName = "tenure", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? Tenure { get; set; }
        [JsonProperty(PropertyName = "tenureLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? TenureLookupTypeId { get; set; }
        [JsonProperty(PropertyName = "tenureLookupTypeDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? TenureLookupTypeDescription { get; set; }
        [JsonProperty(PropertyName = "tenureLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? TenureLookupValueId { get; set; }
        [JsonProperty(PropertyName = "rate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public decimal? Rate { get; set; }
        [JsonProperty(PropertyName = "salesPersonId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? SalesPersonId { get; set; }
        [JsonProperty(PropertyName = "repaymentFrequencyLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? RepaymentFrequencyLookupTypeId { get; set; }
        [JsonProperty(PropertyName = "repaymentFrequencyDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? RepaymentFrequencyDescription { get; set; }
        [JsonProperty(PropertyName = "repaymentFrequencyLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? RepaymentFrequencyLookupValueId { get; set; }
        [JsonProperty(PropertyName = "vehicleRegistrationNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VehicleRegistrationNumber { get; set; }=default!;
        [JsonProperty(PropertyName = "leadCurrentStatusId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? LeadCurrentStatusId { get; set; }
        [JsonProperty(PropertyName = "leadCurrentStatusDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LeadCurrentStatusDescription { get; set; }
        [JsonProperty(PropertyName = "cancelledBy", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? CancelledBy { get; set; }
        [JsonProperty(PropertyName = "cancelledDate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? CancelledDate { get; set; }
        [JsonProperty(PropertyName = "cancellationRemarks", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? CancellationRemarks { get; set; } = default!;
        [JsonProperty(PropertyName = "leavePeriod", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? LeavePeriod { get; set; } = default!;
        [JsonProperty(PropertyName = "documentCategoryId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? DocumentCategoryId { get; set; }

        [JsonProperty(PropertyName = "documentName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? DocumentName { get; set; }

        [JsonProperty(PropertyName = "fieldExecutiveId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? FieldExecutiveId { get; set; }

        [JsonProperty(PropertyName = "fieldExecutiveName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? FieldExecutiveName { get; set; }
    }
}

using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class LeadNonIndividualDetail
    {
        [JsonProperty(PropertyName = "publicCloselyLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)] 
        public int PublicCloselyLookupTypeId { get; set; }
        [JsonProperty(PropertyName = "publicCloselyLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int PublicCloselyLookupValueId { get; set; }
        [JsonProperty(PropertyName = "publicCloselyDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? PublicCloselyDescription { get; set; }
        [JsonProperty(PropertyName = "directorCount", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int DirectorCount { get; set; }
        [JsonProperty(PropertyName = "listedExchange", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string ListedExchange { get; set; }
        [JsonProperty(PropertyName = "paidUpCapital", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public decimal? PaidUpCapital { get; set; }
        [JsonProperty(PropertyName = "faceValueShare", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public decimal? FaceValueShare { get; set; }
        [JsonProperty(PropertyName = "bookValueShare", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public decimal? BookValueShare { get; set; }
        [JsonProperty(PropertyName = "businessProfile", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? BusinessProfile { get; set; }
        [JsonProperty(PropertyName = "geographicalCoverage", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? GeographicalCoverage { get; set; }
        [JsonProperty(PropertyName = "branchCount", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? BranchCount { get; set; }
        [JsonProperty(PropertyName = "institutionLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int InstitutionLookupTypeId { get; set; }
        [JsonProperty(PropertyName = "institutionLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int InstitutionLookupValueId { get; set; }
        [JsonProperty(PropertyName = "promoterStakePercentage", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public decimal? PromoterStakePercentage { get; set; }
        [JsonProperty(PropertyName = "spouseEmploymentLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int SpouseEmploymentLookupValueId { get; set; }
        [JsonProperty(PropertyName = "jvPartnerName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? JVPartnerName { get; set; }
        [JsonProperty(PropertyName = "jvPartnerPercentage", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public decimal? JVPartnerPercentage { get; set; }
        [JsonProperty(PropertyName = "ceoName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? CeoName { get; set; }
        [JsonProperty(PropertyName = "ceoDateofBirth", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? CeoDateofBirth { get; set; }
        [JsonProperty(PropertyName = "ceoWeddingDate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? CeoWeddingDate { get; set; }
        [JsonProperty(PropertyName = "ceoExperience", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? CeoExperience { get; set; }
        [JsonProperty(PropertyName = "residentialAddress", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? ResidentialAddress { get; set; }
        [JsonProperty(PropertyName = "industryLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? IndustryLookupTypeId { get; set; }
        [JsonProperty(PropertyName = "industryLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? IndustryLookupValueId { get; set; }
        [JsonProperty(PropertyName = "industryDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? IndustryDescription { get; set; }
    }
}

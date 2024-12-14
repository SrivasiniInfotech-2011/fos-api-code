using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class Lead : BaseModel
    {
        [JsonProperty(PropertyName = "companyId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int CompanyId { get; set; }

        [JsonProperty(PropertyName = "userId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int UserId { get; set; }

        [JsonProperty(PropertyName = "lobId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int LobId { get; set; }

        [JsonProperty(PropertyName = "lobDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LobDescription { get; set; }

        [JsonProperty(PropertyName = "leadDate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? LeadDate { get; set; }

        [JsonProperty(PropertyName = "locationId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int LocationId { get; set; }

        [JsonProperty(PropertyName = "customerId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int CustomerId { get; set; }

        [JsonProperty(PropertyName = "customerCode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? CustomerCode { get; set; }

        [JsonProperty(PropertyName = "header", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public LeadHeader? Header { get; set; }

        [JsonProperty(PropertyName = "individualDetail", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public LeadIndividualDetail? IndividualDetail { get; set; }

        [JsonProperty(PropertyName = "nonIndividualDetail", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public LeadNonIndividualDetail? NonIndividualDetail { get; set; }

        [JsonProperty(PropertyName = "guarantors", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public List<LeadGuarantor>? Guarantors { get; set; }

        [JsonProperty(PropertyName = "followUps", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public List<LeadFollowUpDetail>? FollowUps { get; set; }

        [JsonProperty(PropertyName = "asset", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public LeadAssetDetail? Asset { get; set; }

        [JsonProperty(PropertyName = "approval", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public LeadApproval? Approval { get; set; }
        [JsonProperty(PropertyName = "leadProspectDetail", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public LeadProspectDetail? LeadProspectDetail { get; set; }
    }
}

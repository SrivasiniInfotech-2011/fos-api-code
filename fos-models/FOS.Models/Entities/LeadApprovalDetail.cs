using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class LeadApprovalDetail
    {

        [JsonProperty(PropertyName = "approvalDetailId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? ApprovalDetailId { get; set; }
        [JsonProperty(PropertyName = "approvalHeaderId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? ApprovalHeaderId { get; set; }
        [JsonProperty(PropertyName = "leadDataLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? LeadDataLookupTypeId { get; set; }
        [JsonProperty(PropertyName = "leadDataLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)] 
        public int? LeadDataLookupValueId { get; set; }
        [JsonProperty(PropertyName = "financeAmount", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)] 
        public decimal? FinanceAmount { get; set; }
        [JsonProperty(PropertyName = "tenure", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)] 
        public int? Tenure { get; set; }
        [JsonProperty(PropertyName = "rate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)] 
        public decimal? Rate { get; set; }
    }
}

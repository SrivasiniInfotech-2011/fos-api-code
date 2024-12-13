using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class LeadFollowUpDetail
    {
        [JsonProperty(PropertyName = "followupId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)] 
        public int? FollowupId { get; set; }
        [JsonProperty(PropertyName = "activityDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)] 
        public string? ActivityDescription { get; set; }
    }
}

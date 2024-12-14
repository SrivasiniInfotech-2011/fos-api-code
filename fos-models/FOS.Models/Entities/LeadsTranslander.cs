using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class LeadsTranslander
    {
        [JsonProperty(PropertyName = "totalRecords", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int TotalRecords { get; set; }
        [JsonProperty(PropertyName = "leads", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public List<LeadHeader>? Leads { get; set; }
    }
}

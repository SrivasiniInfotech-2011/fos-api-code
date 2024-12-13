using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class FieldExecutive
    {
        [JsonProperty(PropertyName = "fieldExecutiveId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? FieldExecutiveId { get; set; }
        [JsonProperty(PropertyName = "fieldExecutiveName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? FieldExecutiveName { get; set; }
    }
}

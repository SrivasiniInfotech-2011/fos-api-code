using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class LeadStatus
    {
        /// <summary>
        /// Id for th Status Object.
        /// </summary>
        [JsonProperty(PropertyName = "statusId",NullValueHandling =NullValueHandling.Ignore,Required =Required.Default)]
        public int StatusId { get; set; }

        /// <summary>
        /// Description of the Status.
        /// </summary>
        [JsonProperty(PropertyName = "statusDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? StatusDescription { get; set; }
    }
}

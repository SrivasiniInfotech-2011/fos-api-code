using Newtonsoft.Json;
namespace FOS.Models.Entities
{
    /// <summary>
    /// Lookup Class
    /// </summary>
    public class Lookup
    {
        /// <summary>
        /// Lookup Type Id.
        /// </summary>
        [JsonProperty(PropertyName = "lookupTypeId", NullValueHandling =NullValueHandling.Ignore,Required =Required.Default)]
        public int? LookupTypeId { get; set; }

        /// <summary>
        /// Lookup Type Description
        /// </summary>
        [JsonProperty(PropertyName = "lookupTypeDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LookupTypeDescription { get; set; }

        /// <summary>
        /// Lookup Value Id.
        /// </summary>
        [JsonProperty(PropertyName = "lookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? LookupValueId { get; set; }

        /// <summary>
        /// Lookup Value Id.
        /// </summary>
        [JsonProperty(PropertyName = "lookupValueDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LookupValueDescription { get; set; }
    
    }
}

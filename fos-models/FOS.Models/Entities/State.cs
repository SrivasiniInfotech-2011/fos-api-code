using Newtonsoft.Json;

namespace FOS.Models.Constants
{
    /// <summary>
    /// State.
    /// </summary>
    internal class State
    {
        /// <summary>
        /// Lookup Type Id.
        /// </summary>
        [JsonProperty(PropertyName = "stateId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? StateId { get; set; }

        /// <summary>
        /// Lookup Type Description
        /// </summary>
        [JsonProperty(PropertyName = "stateName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? StateName { get; set; }
    }
}

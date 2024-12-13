using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class Address
    {
        /// <summary>
        /// Address Line 1.
        /// </summary>
        [JsonProperty(PropertyName = "addressLine1", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AddressLine1 { get; set; }

        /// <summary>
        /// Address Line 2.
        /// </summary>
        [JsonProperty(PropertyName = "addressLine2", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AddressLine2 { get; set; }

        /// <summary>
        /// Address Landmark.
        /// </summary>
        [JsonProperty(PropertyName = "landmark", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Landmark { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        [JsonProperty(PropertyName = "city", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? City { get; set; }

        /// <summary>
        /// State Id.
        /// </summary>
        [JsonProperty(PropertyName = "stateId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? StateId { get; set; }

        /// <summary>
        /// Country Id.
        /// </summary>
        [JsonProperty(PropertyName = "countryId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? CountryId { get; set; }

        /// <summary>
        ///  Pincode.
        /// </summary>
        [JsonProperty(PropertyName = "pincode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Pincode { get; set; }

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.Models.Entities
{
    public class Location
    {
        /// <summary>
        /// Lookup Type Id.
        /// </summary>
        [JsonProperty(PropertyName = "locationId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? LocationId { get; set; }

        /// <summary>
        /// Lookup Type Description
        /// </summary>
        [JsonProperty(PropertyName = "locationName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LocationName { get; set; }
    }
}

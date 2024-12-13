using FOS.Models.Entities;
using Newtonsoft.Json;

namespace FOS.Models.Requests
{
    public class CreateProspectRequestModel
    {
        [JsonProperty(propertyName:"userId",Required =Required.Default,NullValueHandling = NullValueHandling.Ignore)]
        public int UserId { get; set; }

        [JsonProperty(propertyName: "prospect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Prospect? Prospect { get; set; }
    }
}

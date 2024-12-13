using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class DocumentCategory
    {
        [JsonProperty(PropertyName = "documentCategoryId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? DocumentCategoryId { get; set; }
        [JsonProperty(PropertyName = "documentCategoryDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? DocumentCategoryDescription { get; set; }
    }
}

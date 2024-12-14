using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class LeadAssetDetail
    {
        [JsonProperty(PropertyName = "assetClassId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int AssetClassId { get; set; }
        [JsonProperty(PropertyName = "assetClassDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AssetClassDescription { get; set; }
        [JsonProperty(PropertyName = "assetMakeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int AssetMakeId { get; set; }
        [JsonProperty(PropertyName = "assetMakeDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AssetMakeDescription { get; set; }
        [JsonProperty(PropertyName = "assetTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int AssetTypeId { get; set; }
        [JsonProperty(PropertyName = "assetTypeDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AssetTypeDescription { get; set; }
        [JsonProperty(PropertyName = "assetModelId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int AssetModelId { get; set; }
        [JsonProperty(PropertyName = "engineNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? EngineNumber { get; set; }

        [JsonProperty(PropertyName = "vehicleNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VehicleNumber { get; set; }
        [JsonProperty(PropertyName = "chasisNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? ChasisNumber { get; set; }
        [JsonProperty(PropertyName = "serialNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? SerialNumber { get; set; }
        [JsonProperty(PropertyName = "ownershipLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int OwnershipLookupTypeId { get; set; }
        [JsonProperty(PropertyName = "ownershipLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int OwnershipLookupValueId { get; set; }
        [JsonProperty(PropertyName = "ownershipDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? OwnershipDescription { get; set; }
        [JsonProperty(PropertyName = "model", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Model { get; set; }
        [JsonProperty(PropertyName = "vehicleTypeLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int VehicleTypeLookupTypeId { get; set; }
        [JsonProperty(PropertyName = "vehicleTypeLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int VehicleTypeLookupValueId { get; set; }
        [JsonProperty(PropertyName = "vehicleTypeDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VehicleTypeDescription { get; set; }
        [JsonProperty(PropertyName = "taxTypeLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int TaxTypeLookupTypeId { get; set; }
        [JsonProperty(PropertyName = "taxTypeLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int TaxTypeLookupValueId { get; set; }
        [JsonProperty(PropertyName = "taxTypeDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? TaxTypeDescription { get; set; }
        [JsonProperty(PropertyName = "fuelTypeLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int FuelTypeLookupTypeId { get; set; }
        [JsonProperty(PropertyName = "fuelTypeLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int FuelTypeLookupValueId { get; set; }

        [JsonProperty(PropertyName = "fuelTypeDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? FuelTypeDescription { get; set; }

        [JsonProperty(PropertyName = "modelDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? ModelDescription { get; set; }
    }
}

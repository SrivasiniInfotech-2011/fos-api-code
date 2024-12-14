using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class LeadIndividualDetail
    {

        [JsonProperty(PropertyName = "houseLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)] 
        public int HouseLookupTypeId { get; set; }

        [JsonProperty(PropertyName = "houseLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int HouseLookupValueId { get; set; }

        [JsonProperty(PropertyName = "houseTypeDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? HouseTypeDescription { get; set; }

        [JsonProperty(PropertyName = "doorFloorNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? DoorFloorNumber { get; set; }

        [JsonProperty(PropertyName = "houseStatusLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int HouseStatusLookupTypeId { get; set; }

        [JsonProperty(PropertyName = "houseStatusLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int HouseStatusLookupValueId { get; set; }

        [JsonProperty(PropertyName = "houseStatusDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? HouseStatusDescription { get; set; }

        [JsonProperty(PropertyName = "maritialStatusLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int MaritialStatusLookupTypeId { get; set; }

        [JsonProperty(PropertyName = "maritialStatusLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int MaritialStatusLookupValueId { get; set; }

        [JsonProperty(PropertyName = "maritialStatusDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? MaritialStatusDescription { get; set; }

        [JsonProperty(PropertyName = "fatherName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? FatherName { get; set; }

        [JsonProperty(PropertyName = "motherName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? MotherName { get; set; }

        [JsonProperty(PropertyName = "spouseName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? SpouseName { get; set; }

        [JsonProperty(PropertyName = "employmentLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int EmploymentLookupTypeId { get; set; }

        [JsonProperty(PropertyName = "employmentLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int EmploymentLookupValueId { get; set; }

        [JsonProperty(PropertyName = "employmentTypeDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? EmploymentTypeDescription { get; set; }

        [JsonProperty(PropertyName = "spouseEmploymentLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int SpouseEmploymentLookupTypeId { get; set; }

        [JsonProperty(PropertyName = "spouseEmploymentLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int SpouseEmploymentLookupValueId { get; set; }

        [JsonProperty(PropertyName = "spouseEmploymentDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? SpouseEmploymentDescription { get; set; }

        [JsonProperty(PropertyName = "adultDependents", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int AdultDependents { get; set; }

        [JsonProperty(PropertyName = "childDependents", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int ChildDependents { get; set; }

        [JsonProperty(PropertyName = "ownTwoWheeler", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? OwnTwoWheeler { get; set; }

        [JsonProperty(PropertyName = "ownFourWheeler", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? OwnFourWheeler { get; set; }

        [JsonProperty(PropertyName = "ownHeavyVehicle", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? OwnHeavyVehicle { get; set; }

        [JsonProperty(PropertyName = "monthlySalary", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public decimal? MonthlySalary { get; set; }

        [JsonProperty(PropertyName = "spouseSalary", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public decimal? SpouseSalary { get; set; }

        [JsonProperty(PropertyName = "houseRentalAmount", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public decimal? HouseRentalAmount { get; set; }

        [JsonProperty(PropertyName = "existingLoanCount", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public decimal? ExistingLoanCount { get; set; }

        [JsonProperty(PropertyName = "existingLoanEmi", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public decimal? ExistingLoanEmi { get; set; }

        [JsonProperty(PropertyName = "leadRemarks", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LeadRemarks { get; set; }
    }
}

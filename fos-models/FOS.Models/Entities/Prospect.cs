using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    /// <summary>
    /// Prospect Object.
    /// </summary>
    public class Prospect
    {
        /// <summary>
        /// Prospect Id.
        /// </summary>
        [JsonProperty(PropertyName = "companyId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? CompanyId { get; set; }

        /// <summary>
        /// Prospect Id.
        /// </summary>
        [JsonProperty(PropertyName = "prospectId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? ProspectId { get; set; }

        /// <summary>
        /// Location Description.
        /// </summary>
        [JsonProperty(PropertyName = "prospectCode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? ProspectCode { get; set; }

        /// <summary>
        /// Location Id
        /// </summary>
        [JsonProperty(PropertyName = "locationId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? LocationId { get; set; }

        /// <summary>
        /// Location Description.
        /// </summary>
        [JsonProperty(PropertyName = "locationDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LocationDescription { get; set; }

        /// <summary>
        /// Date Of Birth.
        /// </summary>
        [JsonProperty(PropertyName = "dateofBirth", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? DateofBirth { get; set; }

        /// <summary>
        /// ProspectDate.
        /// </summary>
        [JsonProperty(PropertyName = "prospectDate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? ProspectDate { get; set; }

        /// <summary>
        /// Prospect Type.
        /// </summary>
        [JsonProperty(PropertyName = "prospectTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? ProspectTypeId { get; set; }

        /// <summary>
        /// Customer Id.
        /// </summary>
        [JsonProperty(PropertyName = "customerId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// Customer Code.
        /// </summary>
        [JsonProperty(PropertyName = "customerCode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? CustomerCode { get; set; }

        /// <summary>
        /// Gender Id.
        /// </summary>
        [JsonProperty(PropertyName = "genderId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? GenderId { get; set; }

        /// <summary>
        /// Gender Name.
        /// </summary>
        [JsonProperty(PropertyName = "genderName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? GenderName { get; set; }

        /// <summary>
        /// Prospect Name.
        /// </summary>
        [JsonProperty(PropertyName = "prospectName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? ProspectName { get; set; }

        /// <summary>
        /// Mobile Number.
        /// </summary>
        [JsonProperty(PropertyName = "mobileNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? MobileNumber { get; set; }

        /// <summary>
        /// Alternate Mobile Number.
        /// </summary>
        [JsonProperty(PropertyName = "alternateMobileNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AlternateMobileNumber { get; set; }

        /// <summary>
        /// WebSite.
        /// </summary>
        [JsonProperty(PropertyName = "website", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Website { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        [JsonProperty(PropertyName = "email", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Email { get; set; }

        /// <summary>
        /// Communication Address.
        /// </summary>
        [JsonProperty(PropertyName = "communicationAddress", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public Address? CommunicationAddress { get; set; }

        /// <summary>
        /// Permanent Address.
        /// </summary>
        [JsonProperty(PropertyName = "permanentAddress", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public Address? PermanentAddress { get; set; }

        /// <summary>
        /// Aadhar Number.
        /// </summary>
        [JsonProperty(PropertyName = "aadharNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AadharNumber { get; set; }

        /// <summary>
        /// Aadhar Image Path.
        /// </summary>
        [JsonProperty(PropertyName = "aadharImagePath", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AadharImagePath { get; set; }

        /// <summary>
        /// PAN Card Number.
        /// </summary>
        [JsonProperty(PropertyName = "panNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? PanNumber { get; set; }

        /// <summary>
        /// PAN Card Image Path.
        /// </summary>
        [JsonProperty(PropertyName = "panNumberImagePath", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? PanNumberImagePath { get; set; }

        /// <summary>
        /// Prospect Image Path.
        /// </summary>
        [JsonProperty(PropertyName = "prospectImagePath", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? ProspectImagePath { get; set; }

    }
}

using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class LeadGuarantor
    {
        [JsonProperty(PropertyName = "genderId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? GenderId { get; set; }

        [JsonProperty(PropertyName = "guarantorTypeLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? GuarantorTypeLookupTypeId { get; set; }

        [JsonProperty(PropertyName = "guarantorTypeLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? GuarantorTypeLookupValueId { get; set; }

        [JsonProperty(PropertyName = "guarantorTypeDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? GuarantorTypeDescription { get; set; }

        [JsonProperty(PropertyName = "guarantorRelationshipLookupTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? GuarantorRelationshipLookupTypeId { get; set; }

        [JsonProperty(PropertyName = "guarantorRelationshipLookupValueId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? GuarantorRelationshipLookupValueId { get; set; }

        [JsonProperty(PropertyName = "guarantorRelationshipDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? GuarantorRelationshipDescription { get; set; }

        [JsonProperty(PropertyName = "guarantorAmount", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public decimal? GuarantorAmount { get; set; }

        [JsonProperty(PropertyName = "guarantorName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? GuarantorName { get; set; }

        [JsonProperty(PropertyName = "guaranterDateOfBirth", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? GuaranterDateOfBirth { get; set; }

        [JsonProperty(PropertyName = "mobileNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? MobileNumber { get; set; }

        [JsonProperty(PropertyName = "alternateMobileNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AlternateMobileNumber { get; set; }

        [JsonProperty(PropertyName = "email", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Email { get; set; }

        [JsonProperty(PropertyName = "website", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Website { get; set; }

        [JsonProperty(PropertyName = "aadharNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AadharNumber { get; set; }

        [JsonProperty(PropertyName = "aadharImagePath", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AadharImagePath { get; set; }
        [JsonProperty(PropertyName = "aadharImageContent", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AadharImageContent { get; set; }

        [JsonProperty(PropertyName = "panNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? PanNumber { get; set; }

        [JsonProperty(PropertyName = "panImagePath", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? PanImagePath { get; set; }

        [JsonProperty(PropertyName = "panImageContent", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? PanImageContent { get; set; }

        [JsonProperty(PropertyName = "guarantorImagePath", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? GuarantorImagePath { get; set; }

        [JsonProperty(PropertyName = "guarantorImageContent", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? GuarantorImageContent { get; set; }

        [JsonProperty(PropertyName = "prospectId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? ProspectId { get; set; }

        [JsonProperty(PropertyName = "prospectCode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? ProspectCode { get; set; }

        [JsonProperty(PropertyName = "communicationAddress", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public Address? CommunicationAddress { get; set; }

        [JsonProperty(PropertyName = "permanentAddress", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public Address? PermanentAddress { get; set; }
    }
}

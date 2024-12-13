using System;
using System.Text.Json.Serialization;

namespace FOS.Models.Entities
{
    public class User
    {
        public int? UserId { get; set; }
        public string? UserLoginId { get; set; }
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        public string? UserEmail { get; set; }
        public string? UserName { get; set; }
        [JsonIgnore()]
        public string? Passsword { get; set; }
        public int? UserLevelId { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string? UserTheme { get; set; }
        public int? CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyCode { get; set; }
        public string? LevelAccess { get; set; }
        public string? CountryName { get; set; }
        public string? UserType { get; set; }
        public string? MarqueeText { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public DateTime? LncSerialDate { get; set; }
        public DateTime? LncDate { get; set; }
        public string? SessionId { get; set; }
        public long SessionExpireDate { get; set; }
    }
}

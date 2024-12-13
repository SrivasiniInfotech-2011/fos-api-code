namespace FOS.Models.Constants
{
    public class Constants
    {
        public const string APP_SECRET = "wSGnVqSnc@4iNj2Qe^S-8ZnvEHQ-UyGS~y)[;yhJdt'#ox<vG%Mp8Gn{EZyG#Db";
        public const string APP_SCOPE = "amsApiRequestScope";
        public const string APP_CLIENT_ID = "A25A96F4D2E6193E5D28F52176622";
        public const string IdentityServerConfigurationKey = "IdentityServerUrl";
        public const string Passphrase = "Al!5(iV3@aij%9hT";
        public const string LeadIdString = "{LEAD_ID}";

        /// <summary>
        /// User Claims.
        /// </summary>
        public static class UserClaim
        {
            public const string Role = "role";
            public const string Admin = "admin";
            public const string User = "user";
            public const string DataEventRecords = "userManagementApi";
            public const string AdminDataEventRecords = "userManagementApi.admin";
            public const string UserAdminEventRecords = "userManagementApi.user";
            public const string ScopeDisplayName = "Scope for the FOS API Resource";
        }

        /// <summary>
        /// Api Resources
        /// </summary>
        public static class ApiResource
        {
            public const string Role = "role";
            public const string Admin = "admin";
            public const string User = "user";
            public const string UserApi = "userManagementApi";
            public const string ApiResourceSecret = "C8EF369FEAD9FF58A847244243A6B";
            public const string UserApiScope = "userApiScope";
            public const string UserApiResouceDisplayName = "User API";
        }

        /// <summary>
        /// Contains constants for special characters.
        /// </summary>
        public static class Characters
        {
            /// <summary>
            /// The constant for ampersand character.
            /// </summary>
            public const char Ampersand = '@';

            /// <summary>
            /// The constant for backslash character.
            /// </summary>
            public const char Backslash = '\\';

            /// <summary>
            /// The constant for colon character.
            /// </summary>
            public const char Colon = ':';

            /// <summary>
            /// The constant for comma character.
            /// </summary>
            public const char Comma = ',';

            /// <summary>
            /// The constant for forward slash character.
            /// </summary>
            public const char ForwardSlash = '/';

            /// <summary>
            /// The constant for period character.
            /// </summary>
            public const char Period = '.';

            /// <summary>
            /// The constant for pipe character.
            /// </summary>
            public const char Pipe = '|';

            /// <summary>
            /// The constant for round bracket close character.
            /// </summary>
            public const char RoundBracketClose = ')';

            /// <summary>
            /// The constant for round bracket open character.
            /// </summary>
            public const char RoundBracketOpen = '(';

            /// <summary>
            /// The constant for space character.
            /// </summary>
            public const char Space = ' ';

            /// <summary>
            /// The constant for square bracket close character.
            /// </summary>
            public const char SquareBracketClose = ']';

            /// <summary>
            /// The constant for square bracket open character.
            /// </summary>
            public const char SquareBracketOpen = '[';

            /// <summary>
            /// The constant for question mark character.
            /// </summary>
            public const char QuestionMark = '?';

            /// <summary>
            /// The constant for asterisk mark character.
            /// </summary>
            public const char Asterisk = '*';

            /// <summary>
            /// The constant for carat mark character.
            /// </summary>
            public const char Carat = '^';

            /// <summary>
            /// The constant for double quote character.
            /// </summary>
            public const char DoubleQuote = '"';

            /// <summary>
            /// The constant for equals character.
            /// </summary>
            public const char Equality = '=';
        }

        /// <summary>
        /// Contains keys for different services used in the application.
        /// </summary>
        public static class FOSServiceKey
        {
            /// <summary>
            /// Contains keys for different file exporters used in the application.
            /// </summary>
            public static class FOSFileExporter
            {
                /// <summary>
                /// The key for the Excel file exporter service.
                /// </summary>
                public const string Excel = "excel";
            }
        }

        /// <summary>
        /// Contains constants related to web configurations.
        /// </summary>
        public static class Web
        {
            /// <summary>
            /// Contains constants related to authorization.
            /// </summary>
            public static class Authorization
            {
                /// <summary>
                /// The name of the request header that provides authorization info.
                /// </summary>
                public const string RequestHeaderAuthorizationKey = "Authorization";

                /// <summary>
                /// The authorization type to use.
                /// </summary>
                public const string Type = "Bearer";

                /// <summary>
                /// Contains constants for claim types.
                /// </summary>
                public static class ClaimType
                {
                    /// <summary>
                    /// The claim type for client ID.
                    /// </summary>
                    public const string ClientId = "clientId";

                    /// <summary>
                    /// The claim type for email.
                    /// </summary>
                    public const string Email = "email";

                    /// <summary>
                    /// The claim type for first name.
                    /// </summary>
                    public const string FirstName = "firstName";

                    /// <summary>
                    /// The claim type for last name.
                    /// </summary>
                    public const string LastName = "lastName";

                    /// <summary>
                    /// The claim type for login name.
                    /// </summary>
                    public const string LoginName = "loginName";

                    /// <summary>
                    /// The claim type for params.
                    /// </summary>
                    public const string Params = "params";

                    /// <summary>
                    /// The claim type for SAM account name.
                    /// </summary>
                    public const string ParamsSamAccountName = "SAM-Account-Name";

                    /// <summary>
                    /// The claim type for staff ID.
                    /// </summary>
                    public const string StaffId = "staffId";
                }
            }

            /// <summary>
            /// Contains constants for content types used in web requests and responses.
            /// </summary>
            public static class ContentType
            {
                /// <summary>
                /// The content type for JSON data format.
                /// </summary>
                /// <remarks>
                /// This constant is used to set the 'Content-Type' header of HTTP requests and responses to 'application/json'.
                /// This indicates that the body of the request or response is formatted as JSON.
                /// </remarks>
                public const string Json = "application/json";

                /// <summary>
                /// The content type for Office Excel data format.
                /// </summary>
                /// <remarks>
                /// This constant is used to set the 'Content-Type' header of HTTP requests and responses to 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet'.
                /// This indicates that the body of the request or response is formatted as an Office Excel document.
                /// </remarks>
                public const string OfficeExcel = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            }
        }

        /// <summary>
        /// Sql Column Names.
        /// </summary>
        public static class SqlColumnNames
        {
            public const string ModuleName = "Module_Name";
            public const string ProgramCode = "Program_Code";
            public const string ProspectCode = "Prospect_Code";
            public const string ProspectId = "Prospect_ID";
            public const string ProspectDate = "Prospect_Date";
            public const string LocationId = "Location_ID";
            public const string LocationDescription = "Location_Description";
            public const string ProspectName = "Prospect_Name";
            public const string ProspectTypeId = "Prospect_Type_ID";
            public const string GenderId = "Gender_ID";
            public const string GenderName = "Gender_Name";
            public const string DateofBirth = "Prospect_DateofBirth";
            public const string MobileNumber = "Mobile_Number";
            public const string AlternateMobileNumber = "Alternate_MobileNumber";
            public const string Website = "Website";
            public const string Email = "Email";
        }

        /// <summary>
        /// Display Messages.
        /// </summary>
        public static class Messages
        {
            public const string PROSPECT_ADDED_SUCCESSFULLY = "The Prospect has been submitted Successfully";
            public const string PROSPECT_AADHAR_ALREADY_EXISTS = "The given Aadhar Card Number already exists in our Records.Please verify and try again";
            public const string PROSPECT_PAN_ALREADY_EXISTS = "The given PAN Card Number already exists in our Records.Please verify and try again";
            public const string USER_ID_EMPTY = "UserId should not be empty";
            public const string COMPANY_ID_EMPTY = "Company should not be empty";
            public const string LOB_ID_EMPTY = "Line of Business should not be empty";
            public const string MOBILE_NUMBER_EMPTY = "Mobile Number should not be empty";
            public const string AAADHAR_AND_PAN_EMPTY = "Either Aadhar or PAN Number should be provided.";
            public const string CREATE_PROSPECT_EMPTY = "Prospect Details should not be null.";
            public const string PROSPECT_DATE_EMPTY = "Prospect Date should not be null.";
            public const string CUSTOMER_ID_EMPTY = "Customer Id should not be null.";
            public const string PROSPECT_TYPE_ID_EMPTY = "Prospect Type Id should not be null.";
            public const string PROSPECT_NAME_EMPTY = "Prospect Name should not be null.";
            public const string COMMS_ADDRESSLINE1_EMPTY = "Communication Address Line 1 should not be null.";
            public const string COMMS_ADDRESSLINE2_EMPTY = "Communication Address Line 2 should not be null.";
            public const string COMMS_LANDMARK_EMPTY = "Communication Landmark should not be null.";
            public const string COMMS_CITY_EMPTY = "Communication City should not be null.";
            public const string COMMS_STATE_EMPTY = "Communication State should not be null.";
            public const string COMMS_COUNTRY_EMPTY = "Communication Country should not be null.";
            public const string COMMS_PINCODE_EMPTY = "Communication Pincode should not be null.";
            public const string PERMS_ADDRESSLINE1_EMPTY = "Permanent Address Line 1 should not be null.";
            public const string PERMS_ADDRESSLINE2_EMPTY = "Permanent Address Line 2 should not be null.";
            public const string PERMS_LANDMARK_EMPTY = "Permanent Landmark should not be null.";
            public const string PERMS_CITY_EMPTY = "Permanent City should not be null.";
            public const string PERMS_STATE_EMPTY = "Permanent State should not be null.";
            public const string PERMS_COUNTRY_EMPTY = "Permanent Country should not be null.";
            public const string PERMS_PINCODE_EMPTY = "Permanent Pincode should not be null.";
            public const string PAN_EMPTY = "PAN Number should be provided.";
            public const string PAN_IMAGE_EMPTY = "PAN Number image should be provided.";
            public const string PROSPECT_IMAGE_EMPTY = "Prospect Image should be provided.";
            public const string INVALID_USER = "The User with the Login Combnation does not exist. Please check and retry later.";
            public const string LEAD_GUARANTOR_ADDED_SUCCESSFULLY = "The Guarantors have been added successfully to the Lead {LEAD_ID}";
            public const string LEAD_GUARANTOR_ADD_FAILURE = "An Error Occured when trying to add Guarantors to the Lead {LEAD_ID}";
            public const string LEAD_INDIVIDUAL_ADDED_SUCCESSFULLY = "The Individual details have been added successfully to the Lead {LEAD_ID}";
            public const string LEAD_INDIVIDUAL_ADDED_FAILURE = "An Error Occured while adding Individual details to the Lead {LEAD_ID}";
            public const string LEAD_NONINDIVIDUAL_ADDED_SUCCESSFULLY = "The Non-Individual details have been added successfully to the Lead {LEAD_ID}";
            public const string LEAD_NONINDIVIDUAL_ADDED_FAILURE = "An Error Occured while adding Non-Individual details to the Lead {LEAD_ID}";
            public const string LEAD_HEADER_ADDED_SUCCESSFULLY = "The Header details have been added successfully to the Lead {LEAD_ID}";
            public const string LEAD_HEADER_ADDED_FAILURE = "An Error Occured while adding Header details to the Lead {LEAD_ID}";
            public const string NO_RECORDS_FOUND = "No Record exists for the submitted details.Please correct your search and try again.";
        }

        public enum SaveStatus
        {
            OK = 0,
            AADHARALREADYEXISTS = 1,
            PANALREADYEXISTS = 2
        }

        public enum DocumentCategoryOptions
        {
            GENERAL = 1,
            LOAN_DOCUMENTS = 2
        }

        public enum FileOutput
        {
            EXCEL = 1,
            PDF = 2
        }
        public static Dictionary<string, string> ProspectDataColumnNames = new Dictionary<string, string>
        {
            { "Prospect Id", "ProspectId" },
            { "Prospect Code", "ProspectCode" },
            { "Prospect Name", "ProspectName" },
            { "Prospect Date", "ProspectDate" },
            { "Date Of Birth", "DateOfBirth" },
            { "Prospect Type", "ProspectType" },
            { "Contact Number", "ContactNumber" },
            { "Alternate Contact Number", "AlternateContactNumber" },
            { "Customer Code", "CustomerCode" },
            { "Email", "Email" },
            { "Website", "Website" },
            { "Gender", "Gender" },
            { "Industry Group", "IndustryGroup" },
            { "Address Line 1", "AddressLine1" },
            { "Address Line 2", "AddressLine2" },
            { "City", "City" },
            { "Address Contact Number", "AddressContactNumber" },
            { "Address Email", "AddressEmail" },
            { "Address Landmark", "AddressLandmark" },
            { "Pin code", "Pincode" },
            { "Address Website", "AddressWebsite" },
            { "Company Name", "CompanyName" },
            { "Address Type", "AddressType" },
            { "Person", "Person" },
            { "State Name", "StateName" },
            { "Country", "Country" }
        };
    }
}

namespace FOS.Models.Constants
{
    public class SqlCommandConstants
    {
        public const string FOS_ORG_GET_EXISTING_PROPSECT_CUSTOMER_DETAILS = @"FOS_ORG_GET_ExistingPropsectCustomerDetails";
        public const string FOS_GET_PROSPECT_LOOKUP_DATA = @"Select  LookupType_ID as LookupTypeId
                                                         , LookupType_Description as LookupTypeDescription
                                                         , LookupValue_ID as LookupValueId
                                                         , LookupValue_Description as LookupValueDescription
                                                         from FOS_SYSAD_LookupMaster(Nolock)
                                                         Where LookupType_ID in(1 , 2 , 22)
                                                         and Is_Active = 1";

        public const string FOS_GET_BRANCH_LIST = @"Select LM.Location_ID as LocationId                                                                                                 
                                                      ,LCAT.LocationCat_Description as LocationName                                                                       
                                                from FOS_SYSAD_UserLocationMapping(Nolock) ULMP                                                                            
                                                    Inner Join FOS_SYSAD_LocationMaster(Nolock) LM       On LM.Location_ID = ULMP.Location_ID                                                                             
                                                    Inner Join FOS_SYSAD_LocationCategory(Nolock) LCAT   On LCAT.Location_Category_ID = LM.Location_Category_ID                                                           
                                                    Where LM.Company_ID = @CompanyId                                                                                          
                                                    And ULMP.User_ID = @UserId                                                                                                  
                                                    And LM.Is_Operational = 1                                                                                                
                                                    And ULMP.LOB_ID = @LobId                                                                                                
                                                    And LM.Is_Active = @IsActive";

        public const string FOS_ORG_INSERT_ProspectMaster = @"FOS_ORG_INSERT_ProspectMaster";

        public const string FOS_GET_STATE_LOOKUP = @"Select STATE_ID    as LookupValueId
                                                           ,STATE_NAME  as LookupValueDescription
                                                            from FOS_SYSAD_STATEMASTER(Nolock)
                                                            --Where Company_ID = @Company_ID
                                                            Order by STATE_NAME";

        public const string GetUserByUsername = @"FOS_Validate_Login";
        public const string GetUserProgramList = @"FOS_Get_User_ProgrmLists";
        public const string GetUserById = @"SELECT  UM.[User_ID]    as  UserId, 
	                                                UM.[User_Name]  as  UserName,
                                                    UM.[Email_ID]   as  UserEmail
	                                                FROM FOS_SYSAD_UserMaster(nolock) UM  WHERE UM.[User_ID]= @UserLoginID AND UM.Is_Active =1";
        public const string FOS_ORG_INSERT_LEADDETAILS = @"FOS_ORG_Insert_LeadDetails";
        public const string FOS_ORG_GET_LEADPROSPECTDETAILS = "FOS_ORG_GET_LeadProspectDetails";
        public const string FOS_ORG_INSERT_LEADGENERATION_HEADER = "FOS_ORG_INSERT_LeadGeneration_Header";
        public const string FOS_ORG_INSERT_LEADINDIVIDUALDETAILS = "FOS_ORG_INSERT_LeadIndividualDetails";
        public const string FOS_ORG_INSERT_LEADNONINDIVIDUALDETAILS = "FOS_ORG_INSERT_LeadNonIndividualDetails";
        public const string FOS_ORG_GET_ASSETLOOKUP = "FOS_ORG_GET_AssetLookup";
        public const string FOS_ORG_GET_LEADDETAILS = "FOS_ORG_GET_LeadDetails";
        public const string FOS_ORG_INSERT_LEADGUARANTORDETAILS = "FOS_ORG_INSERT_LeadGuarantorDetails";
        public const string FOS_ORG_GET_PROSPECTMASTERLOOKUP = "FOS_ORG_GET_ProspectMasterLookup";
        public const string FOS_ORG_GETLEADSTATUS = @"SELECT LSL.Lead_Status_ID AS StatusId,
                                                             LSL.Status_Description as StatusDescription
                                                        FROM FOS_ORG_LeadStatusLookup LSL";
        public const string FOS_ORG_GET_LEADTRANSLANDER = "FOS_ORG_GET_LeadTranslander_New";
        public const string FOS_GET_LOOKUPS_FOR_LEAD_SCREEN = @"FOS_ORG_GET_LeadGenerationLookup";
        public const string FOS_GET_LOB_LIST = "FOS_Get_LOB_LIST";
        public const string FOS_ORG_GET_USERNAMEAGT = "FOS_ORG_GET_UserNameAGT";
        public const string FOS_SYSAD_DOCUMENT_LOOKUPDETAILS = "FOS_SYSAD_Document_LookupDetails";
        public const string FOS_PROSPECT_EXPORT_QUERY = @"SELECT DISTINCT PH.Prospect_ID AS ProspectId,
				PH.Prospect_Code as ProspectCode,
				PH.Prospect_Name as ProspectName,
				PH.Prospect_Date as ProspectDate,
				PH.Prospect_DateofBirth as DateOfBirth,
				LKPT.LookupValue_Description as ProspectType,
				PH.Contact_Number as ContactNumber,
				PH.Alternate_Contact_Number as AlternateContactNumber,
				PH.Customer_Code as CustomerCode,
				PH.Email_ID as Email,
				PH.Website as Website,
				LKG.LookupValue_Description as Gender,
				LKI.LookupValue_Description as IndustryGroup,
				PA.Address_1 as AddressLine1,
				PA.Address_2 as AddressLine2,
				PA.City as City,
				PA.Contact_Number as AddressContactNumber,
				PA.Email_ID as AddressEmail,
				PA.Landmark as AddressLandmark,
				PA.Pincode as Pincode,
				PA.website as AddressWebsite,
				CMP.Company_Name as CompanyName,
				LKA.LookupValue_Description as AddressType,
				LKP.LookupValue_Description as Person,
				LKS.STATE_NAME as StateName,
				LKC.LookupValue_Description as Country
 FROM	 FOS_ORG_PROSPECTHEADER	PH
		 INNER JOIN [dbo].[FOS_ORG_ProspectAddress]				PA			ON		PA.Prospect_ID					=		PH.Prospect_ID
		 INNER JOIN [dbo].[FOS_SYSAD_CompanyMaster]			    CMP			ON		CMP.Company_ID					=		PH.COMPANY_ID
		 LEFT JOIN  [dbo].[FOS_SYSAD_LookupMaster]				LKPT		ON		LKPT.LookupValue_ID				=		PH.Prospect_LookupValue_ID AND LKPT.LookupType_ID	=	PH.Prospect_LookupType_ID
		 LEFT JOIN  [dbo].[FOS_SYSAD_LookupMaster]				LKG			ON		LKG.LookupValue_ID				=		PH.Gender_LookupValue_ID   AND LKG.LookupType_ID	=	PH.Gender_LookupType_ID
		 LEFT JOIN  [dbo].[FOS_SYSAD_LookupMaster]				LKI			ON		LKI.LookupValue_ID				=		PH.Industry_LookupValue_ID AND LKI.LookupType_ID	=	PH.Industry_LookupType_ID
		 INNER JOIN [dbo].[FOS_SYSAD_STATEMASTER]				LKS			ON		LKS.STATE_ID					=		PA.State_ID
		 LEFT JOIN  [dbo].[FOS_SYSAD_LookupMaster]				LKA			ON		LKA.LookupValue_ID				=		PA.Address_LookupValue_ID	 AND LKA.LookupType_ID	=	PA.Address_LookupType_ID
		 LEFT JOIN  [dbo].[FOS_SYSAD_LookupMaster]				LKC			ON		LKC.LookupValue_ID				=		PA.Country_ID AND LKC.LookupType_ID = 22				
		 LEFT JOIN  [dbo].[FOS_SYSAD_LookupMaster]				LKP			ON		LKP.LookupValue_ID				=		PA.Person_LookupValue_ID AND LKA.LookupType_ID = PA.Person_LookupType_ID";
        public enum Mode
        {
            ADD = 1,
            MODIFY = 2,
            DELETE=3
        }
    }
}

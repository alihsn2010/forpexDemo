using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fopex.DAL.Model.Country
{
    public class ModelCountry
    {

    }
    #region Travel Package Details

    public class TravelPackageDetail_Request
    {
        public string CoverageType { get; set; }
        public string TravelType { get; set; }
        public string WithTution { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string DOB { get; set; }
        public string BusinessType_Id { get; set; }
        
        // GWS
        public GWService_Message_Header GWService_Message_Header { get; set; }
    }



    #endregion


    #region 1st Info
    public class GenResponce_API
    {
        public int Status { get; set; }
        public string Message { get; set; }

    }

    public class CoverageType_API
    {
        public string id { get; set; }
        public string Name { get; set; }
    }

    public class mCountry
    {
        public string ID { get; set; }
        public string Country_Name { get; set; }
        public string Country_Code { get; set; }
    }

    public class TravalType_API
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class TravelPackage_API
    {
        //public int? id { get; set; } = null;
        public string Name { get; set; }
    }

    public class TravalDetailsResponce_API
    {
        public string Id { get; set; }
        public string PackageType { get; set; }
        public string Package { get; set; }
        public string Premium { get; set; }
        public string DiscountPremium { get; set; }
        public string ShortDescription { get; set; }
        //public string LongDescription { get; set; }
        public string Package_text { get; set; }
    }

    public class BeneficiaryRelation
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class TravelPackageSummary
    {
        public string Package { get; set; }
        public string PlanType { get; set; }
        public string MinPrice { get; set; }
        public string MaxPrice { get; set; }
        public string PackageType { get; set; }
        public string IsFamily { get; set; }
        public string Description { get; set; }
        public string LogoInBase64 { get; set; }
    }
    public class PackageSummaryDetails
    {
        public string PackageType { get; set; }
        public string IsFamily { get; set; }
        public string LogoInBase64 { get; set; }
        public string MinPrice { get; set; }
        public string MaxPrice { get; set; }
        public string PlanType { get; set; }
        public string Description { get; set; }

    }

    public class TravelPackageSummaryNew
    {
        public string Package { get; set; }
        public List<PackageSummaryDetails> PSD { get; set; }
    }
    #endregion

    #region Hashing
    public class HashObject
    {
        public string CompnayId { get; set; }
        public object RequestHashObj { get; set; }
    }

    public class HashProperty
    {
        public string HashObj { get; set; }
    }
    #endregion

    #region All Required Info for Policy Creation
    public class PersonalDetails_API
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string PassportNo { get; set; }
        public string CNIC { get; set; }
        public string CityId { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }
    }

    public class InsuranceSummaryDetails_API
    {
        public string PackageId { get; set; }
        public string PackageName { get; set; }
        public string PackageType { get; set; }
    }

    public class BeneficiaryDetails_API
    {
        public string BeneficiaryName { get; set; }
        public string BeneficiaryAddress { get; set; }
        public string BeneficiaryCNIC { get; set; }
        public string BeneficiaryContactNo { get; set; }
        public string BeneficiaryGender { get; set; }
        public string BeneficiaryRelationText { get; set; }
    }

    public class FamilyDetails
    {
        public string FamilyMemberName { get; set; }
        public DateTime FamilyMemberDOB { get; set; }
        public string FamilyMemberCNIC { get; set; }
        public string FamilyMemberRelation { get; set; }
        public string FamilyMemberGender { get; set; }
    }

    public class Gen_Feilds
    {
        public string Gen_feild_1 { get; set; }
        public string Gen_feild_2 { get; set; }
        public string Gen_feild_3 { get; set; }
        public string Gen_feild_4 { get; set; }

    }

    public class TravelDetails_API : HashProperty
    {
        [Required]
        public string Coverage { get; set; }
        [Required]
        public string TravelType { get; set; }
        public string WithTution { get; set; }
        [Required]
        public string StartDate { get; set; }
        [Required]
        public string EndDate { get; set; }
        public string DesitinationId { get; set; }
        [Required]
        public string DOB { get; set; }
    }

    public class TravelDetailsForPorposal_API
    {
        public string Coverage { get; set; }
        public string TravelType { get; set; }
        public string WithTution { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string DesitinationId { get; set; }
        public string DOB { get; set; }
    }

    public class TravelPolicy_API : HashProperty
    {
        public string PolicyNo { get; set; }

    }

    public class ClaimTypes_API
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class InsertTravelClaim_API : HashProperty
    {
        public string PolicyNo { get; set; }
        public int ClaimType_Id { get; set; }
        public string DateOfLoss { get; set; }
        //public int City_ID { get; set; }
        public string CircumstancesOfLoss { get; set; }
        public decimal LossAmount { get; set; }
        public string Remarks { get; set; }
    }

    public class InsertTravelClaim_API_Responce
    {
        public string ClaimNo { get; set; }
        public int ClaimId { get; set; }
        public string Status { get; set; }
    }

    #region Travel Status
    public class GetTravelStatusRequest : HashProperty
    {
        public string ClaimNo { get; set; }
    }

    public class GetTravelStatusResponce
    {
        public string Status { get; set; }
    }
    #endregion


    #endregion

    #region ConvertToPolicy

    public class ConvertToPolicy_API : HashProperty
    {
        public string PorposalNo { get; set; }
        // GWS
        public GWService_Message_Header GWService_Message_Header { get; set; }
    }

    public class ConvertToPolicy_Response
    {
        public string PolicyNo { get; set; }
    }

    public class ConvertToPolicyUBL_Request : HashProperty
    {
        public string PorposalNo { get; set; }
        public string Amount { get; set; }
        public string TransactionStatus { get; set; }
        //  public string TrnasactionId { get; set; }
        public string TransactionId { get; set; }
        public Transaction Transaction { get; set; }
    }
    #region UBL Transaction Object
    public class Transaction
    {
        public string orderId { get; set; }
        public string responseCode { get; set; }
        public string responseClass { get; set; }
        public string responseDescription { get; set; }
        public string responseClassDescription { get; set; }
        public balance balance { get; set; }
        public amount amount { get; set; }
        public fees fees { get; set; }
        public payer payer { get; set; }
        public string uniqueId { get; set; }
    }

    public class balance
    {
        public string value { get; set; }
    }

    public class amount
    {
        public string value { get; set; }
    }

    public class fees
    {
        public string value { get; set; }
    }

    public class payer
    {
        public string Information { get; set; }
    }
    #endregion



    public class ConvertToPolicyUBL_Response
    {
        public string PolicyNo { get; set; }
        public string Result { get; set; }
    }
    #endregion

    #region Mics
    public class Log
    {
        public string MarchantId { get; set; }
        public string FunctionName { get; set; }
        public string RequestType { get; set; }
        public string Request { get; set; }
        public string Responce { get; set; }
        public string ActionType { get; set; }
        public string Exception { get; set; }
        public string IP { get; set; }
    }

    public class HashingModel
    {
        public string isValid { get; set; }
        public string Message { get; set; }
        public string status { get; set; }
        public List<dynamic> Result { get; set; }
    }

    public class ReturnObject
    {
        public string isValid { get; set; }
        public string Message { get; set; }
        public string status { get; set; }
        public string HashObj { get; set; }
        public List<dynamic> Result { get; set; }

    }
    #endregion

    #region Main and Last

    public class InsertLead_API : HashProperty
    {
        public string Mobile { get; set; }
        public string Coverage { get; set; }
        public string TravelType { get; set; }
        public string Package { get; set; }
        public string Effective_Dt { get; set; }
        public string End_Dt { get; set; }
        public string QuoteStatus { get; set; }
        public string CityName { get; set; }
        public string Destination_Id { get; set; }
        public string Province { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public string CNIC { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Response_InsertLead_API
    {
        public string CustomerName { get; set; }
        public string NetPremium_Filer { get; set; }
        public string NetPremium_NonFiler { get; set; }
        public string ProductInfo_Id { get; set; }
        public string Discount { get; set; }
        public string DiscountPercent { get; set; }
        public string GrossPremium { get; set; }
    }

    public class InsuredDetails : HashProperty
    {
        //public Gen_Feilds Gen_Feilds { get; set; } = null;
        public PersonalDetails_API PersonalDetails { get; set; }
        public InsuranceSummaryDetails_API InsuranceSummaryDetails { get; set; }
        [Required]
        public List<BeneficiaryDetails_API> BeneficiaryDetails { get; set; }
        public TravelDetailsForPorposal_API TravelDetails { get; set; }
        public List<FamilyDetails> FamilyDetails { get; set; }
        // GWS
        public GWService_Message_Header GWService_Message_Header { get; set; }

    }
    // GWS
    public class GWService_Message_Header
    {
        public string Source { get; set; }
        public string MessageType { get; set; }
        public string UserId { get; set; }
        //ip
        //
        //public string MarchantKey { get; set; }
        //public string Transaction_Type { get; set; }
    }

    public class Reponse_InsuredDetails
    {
        public string NetPremium_Filer { get; set; }
        public string NetPremium_NonFiler { get; set; }
        public string Discount { get; set; }
        public string DiscountPercent { get; set; }
        public string GrossPremium { get; set; }
        public string Proposal { get; set; }
        //public string NetAmount { get; set; }
        public string CustomerName { get; set; }
        public string Return_URL { get; set; }
    }
    public class HashObjectDetail : HashProperty
    {
        public string JsonObject { get; set; }
    }

    #endregion
}

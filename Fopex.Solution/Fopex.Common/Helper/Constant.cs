using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Fopex.COMMON.Helper
{
    public class Constant
    {
        public static string TravelConnection = ConfigurationManager.ConnectionStrings["testDBEntities"].ConnectionString.ToString();

        public static string EmailSubject = "UBL Digital: Travel Insurance";
        public static string SMSBody(string CustomerName, string ClaimNo) { return CustomerName.Trim() + ", your claim number is " + ClaimNo + ". Questions? Call 021.111.000.301. Thank you for using UBL Digital"; }
        public static string SMSBody_UblPolicy(string CustomerName, string PolicyNo)
        { 
            return "Dear " + CustomerName + ", thank you for choosing UBL! Please check your email for your insurance certificate. Policy Number:"+PolicyNo;
        }
        public static string EmailBody(string CustomerName)
        {
            return @"<html>
                      <body>
                      <p>Dear " + CustomerName.Replace("Mr.","") + @",</p>
                      <p>Thank you for purchasing travel insurance through UBL. Please find attached your insurance certificate.</p>
                      
                      <p>We hope you have a great trip but in case anything goes wrong, you can initiate a claim from the UBL Digital website. All you need is your policy number!</p>
                      
                      <p>In case you have any questions, feel free to reach out to our travel insurance provider, TPL, at info@tplinsurance.com or 111-000-301.</p>

                      <p>Regards,</p>
                        <p>UBL Digital</p>

                      </body>
                      </html>
                     ";

            //return  "Dear " + CustomerName +
            //        "<p>Thank you for purchasing travel insurance through UBL.Please find attached your insurance certificate." +
            //        "We hope you have a great trip but in case anything goes wrong, you can initiate a claim right here.All you need is your policy number!" +
            //        "In case you have any questions, feel free to reach out to us at customer.services@ubl.com.pk or call our travel insurance provider, TPL, on 111 - 000 - 201.</p>";
        }
    }
    public enum ErrorCode
    {
        No_Access = 701,
        Hash_Miss_Matched = 702,
        Controller_Exception = 703,
        Exception = 704,
        Merchant_ID_Error = 705
    };

    //public enum Source
    //{
    //    Mobile ,
    //    Web ,
    //    Portals ,
    //    Others 
    //}



    public enum ObjectResponce
    {
        Accepted = 1,
        Rejected = 2,
        Invalid_Operation = 3,
        Exception = 704
    }
    public class Source
    {
        public const string Mobile = "Mobile";
        public const string Web = "Web";
        public const string Portals = "Portals";
        public const string Others = "Others";
       
    }

    public static class PageAction
    {
        public const string Create = "Create";
        public const string Edit = "Edit";
        public const string View = "View";
        public const string ReadOnly = "ReadOnly";

    }

}
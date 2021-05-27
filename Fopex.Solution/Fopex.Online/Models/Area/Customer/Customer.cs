using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace Fopex.Online.Models.Area.Customer
{

    // this is test ali page

    // this is test ali page2

    public class PageCustomers
    {
        [Key]
        [DisplayName("Customer System No.")]
        public int CustID { get; set; }

        [DisplayName("Customer ID")]
        public string Customer_ID { get; set; }

        [DisplayName("Customer Name")]
        public string Customer_Name { get; set; }

        [DisplayName("Contact Person")]
        public string Contact_Person_Name { get; set; }

        [DisplayName("Phone No.")]
        public string Phone_No { get; set; }

        [DisplayName("Email:")]
        public string Email { get; set; }

        [DisplayName("Address Line 1")]
        public string AddessLine1 { get; set; }

        [DisplayName("Address Line 2")]
        public string AddressLine2 { get; set; }

        [DisplayName("City")]
        public int City { get; set; }

        [DisplayName("State/Province/Emirate")]
        public string State { get; set; }

        [DisplayName("Region")]
        public string Region { get; set; }

        [DisplayName("Country")]
        public int Country { get; set; }

        [DisplayName("Additional Notes:")]
        public string Additional_Notes { get; set; }

        [DisplayName("Customer Type")]
        public string Customer_TypeID { get; set; }

        [DisplayName("Customer Group")]
        public string Customer_GroupID { get; set; }
        
        [DisplayName("Customer Sale Type")]
        public string Customer_Sales_Type_ID { get; set; }

        [DisplayName("Payment Type Group")]
        public string Payment_Type_Group_ID { get; set; }

        [DisplayName("Customer Sale Region")]
        public string Sales_Region { get; set; }
        


        [DisplayName("Invoicing Currency")]
        public string Invoicing_Currency { get; set; }

        [DisplayName("VAT Registration No.")]
        public string VAT_Registration_No { get; set; }

        [DisplayName("EORI Number")]
        public string EORI_Number { get; set; }

        [DisplayName("GLN")]
        public string GLN { get; set; }

        [DisplayName("Bill To Customer Name")]
        public string Bill_To_Customer_Name { get; set; }

        [DisplayName("Payment Term")]
        public string Payment_Term { get; set; }

        [DisplayName("Payment Method")]
        public string Payment_Method { get; set; }

        [DisplayName("Exclude from Aging Report?")]
        public string Exclude_From_Aging_Report { get; set; }

        [DisplayName("Primary Shipment To Location")]
        public string Primary_Shipment_To_Location { get; set; }

        [DisplayName("Secondary Shipment To Location")]
        public string Secondary_Shipment_To_Location { get; set; }

        [DisplayName("Primary Shipment From Location")]
        public string Primary_Shipment_From_Location { get; set; }

        [DisplayName("Secondary Shipment From Location")]
        public string Secondary_Shipment_From_Location { get; set; }

        [DisplayName("Assigned Supervisor Name")]
        public string Assigned_SupervisorID { get; set; }

        [DisplayName("Assigned Salesperson Name")]
        public string Assigned_SalespersonID { get; set; }


    }



}
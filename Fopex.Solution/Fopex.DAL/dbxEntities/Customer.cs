//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fopex.DAL.dbxEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int CustID { get; set; }
        public string Customer_ID { get; set; }
        public string Customer_Name { get; set; }
        public string AddessLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int City { get; set; }
        public string State { get; set; }
        public string Province { get; set; }
        public string Region { get; set; }
        public int Country { get; set; }
        public string Contact_Person_Name { get; set; }
        public string Phone_No { get; set; }
        public string Email { get; set; }
        public string Customer_TypeID { get; set; }
        public string IC_Partner_Code_ID { get; set; }
        public string Salesperson_ID { get; set; }
        public string Invoicing_Currency { get; set; }
        public string VAT_Registration_No { get; set; }
        public string EORI_Number { get; set; }
        public string GLN { get; set; }
        public string Bill_To_Customer_Name { get; set; }
        public string Payment_Term { get; set; }
        public string Payment_Method { get; set; }
        public string Exclude_From_Aging_Report { get; set; }
        public string Primary_Shipment_To_Location { get; set; }
        public string Secondary_Shipment_To_Location { get; set; }
        public string Primary_Shipment_From_Location { get; set; }
        public string Secondary_Shipment_From_Location { get; set; }
    
        public virtual City City1 { get; set; }
        public virtual Country Country1 { get; set; }
    }
}

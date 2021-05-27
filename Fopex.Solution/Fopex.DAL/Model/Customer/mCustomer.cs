using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fopex.DAL.Model.Customer
{
    public class mCustomer
    {

        public int CustID { get; set; }
        public string Customer_ID { get; set; }
        public string Customer_Name { get; set; }
        public string Contact_Person_Name { get; set; }
        public string Phone_No { get; set; }
        public string Email { get; set; }
        public string AddessLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int City { get; set; }
        public string State { get; set; }
        public string Region { get; set; }
        public int Country { get; set; }
        public string Additional_Notes { get; set; }
        public string Customer_TypeID { get; set; }
        public string Customer_GroupID { get; set; }
        public string Customer_Sales_Type_ID { get; set; }
        public string Payment_Type_Group_ID { get; set; }
        public string Sales_Region { get; set; }
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
        public string Assigned_SupervisorID { get; set; }
        public string Assigned_SalespersonID { get; set; }


    }
}

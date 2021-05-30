using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fopex.DAL.Model.Customer
{
    public class mCustomer
    {
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

        [DisplayName("Country")]
        public Nullable<int> Country { get; set; }

        [DisplayName("City")]
        public Nullable<int> City { get; set; }
        [DisplayName("State/Province/Emirate")]
        public string State { get; set; }
        [DisplayName("Region")]
        public string Region { get; set; }

        [DisplayName("Additional Notes:")]
                [DataType(DataType.MultilineText)]
        public string Additional_Notes { get; set; }

        [DisplayName("Customer TypeID")]
        public string Customer_TypeID { get; set; }

        [DisplayName("Customer GroupID")]
        public Nullable<int> Customer_GroupID { get; set; }

        [DisplayName("Customer Sales TypeID")]
        public Nullable<int> Customer_Sales_Type_ID { get; set; }
        [DisplayName("Payment Type Group ID")]
        public Nullable<int> Payment_Type_Group_ID { get; set; }
        [DisplayName("Sales Region")]
        public Nullable<int> Sales_Region { get; set; }
        [DisplayName("Invoicing Currency")]
        public string Invoicing_Currency { get; set; }

        [DisplayName("VAT RegistrationNo")]
        public string VAT_Registration_No { get; set; }

        [DisplayName("EORI_Number")]
        public string EORI_Number { get; set; }

        [DisplayName("GLN")]
        public string GLN { get; set; }
        [DisplayName("Bill_To_Customer_Name")]
        public string Bill_To_Customer_Name { get; set; }
        [DisplayName("Payment_Term")]
        public string Payment_Term { get; set; }
        [DisplayName("Payment_Method")]
        public string Payment_Method { get; set; }

        [DisplayName("Exclude_From_Aging_Report")]
        public string Exclude_From_Aging_Report { get; set; }

        [DisplayName("Primary_Shipment_To_Location")]
        public string Primary_Shipment_To_Location { get; set; }

        [DisplayName("Secondary_Shipment_To_Location")]
        public string Secondary_Shipment_To_Location { get; set; }

        [DisplayName("Primary_Shipment_From_Location")]
        public string Primary_Shipment_From_Location { get; set; }
        [DisplayName("Secondary_Shipment_From_Location")]
        public string Secondary_Shipment_From_Location { get; set; }

        [DisplayName("Assigned_SupervisorID")]
        public Nullable<int> Assigned_SupervisorID { get; set; }
        [DisplayName("Assigned_SalespersonID")]
        public Nullable<int> Assigned_SalespersonID { get; set; }

       // public virtual City City1 { get; set; }








    }
}

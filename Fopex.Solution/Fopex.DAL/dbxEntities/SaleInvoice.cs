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
    
    public partial class SaleInvoice
    {
        public int ID { get; set; }
        public string Invoice_No { get; set; }
        public Nullable<System.DateTime> Inv_Date { get; set; }
        public Nullable<int> Customer_ID { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Ref { get; set; }
        public string Item_Type { get; set; }
        public string Item_No { get; set; }
        public string Item_Description { get; set; }
        public Nullable<int> Qty_Ordered { get; set; }
        public Nullable<int> Qty_Shipped { get; set; }
        public Nullable<int> Qty_Invoiced { get; set; }
        public Nullable<int> Qty_Balance { get; set; }
        public Nullable<int> Payment_TermID { get; set; }
        public string Quotation_Ref { get; set; }
        public Nullable<System.DateTime> Delivery_Date { get; set; }
        public Nullable<int> SalespersonID { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> Amount_Ordered { get; set; }
        public Nullable<decimal> Amount_Invoiced { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public string Type { get; set; }
    }
}

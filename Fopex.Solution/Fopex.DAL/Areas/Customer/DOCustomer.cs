using Fopex.DAL.dbxEntities;
using Fopex.DAL.Model.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fopex.DAL.Areas.Customer
{
    public  class DOCustomer
    {
        public List<mCustomer> GetAll()
        {
            //CityList = new List<mCity>();
            //dbxEntities.City objCity = new dbxEntities.City();

            //using (FopexEntities1 db = new FopexEntities1())



            using (FopexEntities1 db = new FopexEntities1())
            {
                List<mCustomer> CustomersList = new List<mCustomer>();
                try
                {
                    var query = db.Customers.OrderByDescending(a => a.CustID).ToList();
                    if (query != null)
                    {
                        foreach (dbxEntities.Customer cus in query)
                        {
                            mCustomer ModelCustomer = new mCustomer();

                            ModelCustomer.CustID = cus.CustID;
                            ModelCustomer.City = cus.City;

                            ModelCustomer.AddessLine1 = cus.AddessLine1;
                            ModelCustomer.AddressLine2 = cus.AddressLine2;
                            ModelCustomer.Bill_To_Customer_Name = cus.Bill_To_Customer_Name;
                            ModelCustomer.City = cus.City;
                            ModelCustomer.Contact_Person_Name = cus.Contact_Person_Name;
                            ModelCustomer.Country = cus.Country;
                            ModelCustomer.Customer_ID = cus.Customer_ID;
                            ModelCustomer.Customer_Name = cus.Customer_Name;
                            ModelCustomer.Customer_TypeID = cus.Customer_TypeID;
                            //if (cus.Is_Active == true)
                            //{
                            //    ModelCustomer.ActiveStatus = "Active";
                            //}
                            //if (cus.Is_Active == false)
                            //{
                            //    ModelCustomer.ActiveStatus = "Inactive";
                            //}
                            ModelCustomer.Email = cus.Email;
                            ModelCustomer.EORI_Number = cus.EORI_Number;
                            ModelCustomer.Exclude_From_Aging_Report = cus.Exclude_From_Aging_Report;
                            ModelCustomer.GLN = cus.GLN;
                            //ModelCustomer.Position = cus.Position;
                            ModelCustomer.Invoicing_Currency = cus.Invoicing_Currency;
                            ModelCustomer.Payment_Method = cus.Payment_Method;
                            //ModelCustomer.Region = cus.Region;
                            ModelCustomer.Payment_Term = cus.Payment_Term;
                            ModelCustomer.Phone_No = cus.Phone_No;
                            ModelCustomer.Primary_Shipment_From_Location = cus.Primary_Shipment_From_Location;
                            ModelCustomer.Primary_Shipment_To_Location = cus.Primary_Shipment_To_Location;
                            ModelCustomer.Region = cus.Region;
                            ModelCustomer.Secondary_Shipment_From_Location = cus.Secondary_Shipment_From_Location;
                            ModelCustomer.Secondary_Shipment_To_Location = cus.Secondary_Shipment_To_Location;
                            ModelCustomer.Region = cus.Region;
                            ModelCustomer.State = cus.State;
                            ModelCustomer.VAT_Registration_No = cus.VAT_Registration_No;
                                
                            CustomersList.Add(ModelCustomer);

                        }

                    }
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;

                }
                return CustomersList;

            }
        }


        public  mCustomer AddNewCustomer(mCustomer objCustomer)
        {


            return null;

        }


        public mCustomer UpdateCustomer(mCustomer objCustomer)
        {


            return null;

        }

        public mCustomer DeleteCustomer(int CustomerID)
        {


            return null;

        }



    }
}

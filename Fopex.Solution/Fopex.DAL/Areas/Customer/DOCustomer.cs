using Fopex.DAL.dbxEntities;
using Fopex.DAL.Model.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fopex.DAL.Areas.Customer
{
    public class DOCustomer
    {
        public List<mCustomer> GetAll()
        {

            using (FopexEntities1 db = new FopexEntities1())
            {
                List<mCustomer> CustomersList = new List<mCustomer>();
                try
                {
                    var query = db.Customers.OrderByDescending(a => a.CustID).ToList();
                    if (query.Count > 0)
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
                            ModelCustomer.IsActive = cus.IsActive;
                            ModelCustomer.CreatedBy = cus.CreatedBy;
                            ModelCustomer.CreatedOn = cus.CreatedOn;
                            ModelCustomer.IsDelete = cus.IsDelete;
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

        public mCustomer GetByID(long ID)
        {
            try
            {

                using (FopexEntities1 db = new FopexEntities1())
                {


                    var query = db.Customers.Where(a => a.CustID == ID).FirstOrDefault();
                    if (query != null)
                    {
                        mCustomer objCustomer = new mCustomer();
                        objCustomer.CustID = query.CustID;
                        objCustomer.Customer_ID = query.Customer_ID;
                        objCustomer.Customer_Name = query.Customer_Name;
                        objCustomer.Email = query.Email;
                        objCustomer.Phone_No = query.Phone_No;
                        objCustomer.City = query.City;
                        objCustomer.Country = query.Country;
                        objCustomer.Region = query.Region;
                        objCustomer.IsActive = query.IsActive;
                        objCustomer.CreatedBy = query.CreatedBy;
                        objCustomer.CreatedOn = query.CreatedOn;
                        return objCustomer;
                    }

                }
                return null;
            }
            catch (Exception ex)
            {
                //
                return null;

            }
          
        }


        List<mCustomer> CusList;

        public long Add(mCustomer objCustomer)
        {

            FopexEntities1 dd = new FopexEntities1();


            using (FopexEntities1 db = new FopexEntities1())
            {
                long flag = 0;


                var modelCust = new Fopex.DAL.dbxEntities.Customer();
                try
                {



                    if (objCustomer != null)
                    {
                        modelCust.Customer_ID = objCustomer.Customer_ID;
                        modelCust.Customer_Name = objCustomer.Customer_Name;
                        modelCust.Email = objCustomer.Email;
                        modelCust.Phone_No = objCustomer.Phone_No;
                        modelCust.City = objCustomer.City;
                        modelCust.Country = objCustomer.Country;
                        modelCust.Region = objCustomer.Region;
                        modelCust.IsActive = objCustomer.IsActive;
                        modelCust.CreatedBy = objCustomer.CreatedBy;
                        modelCust.CreatedOn = objCustomer.CreatedOn;

                        db.Customers.Add(modelCust);
                        db.SaveChanges();

                        flag = Convert.ToInt64(modelCust.CustID);


                    }
                }
                catch
                {

                    flag = 0;
                }
                return flag;
            }

        }



        public mCustomer Update(mCustomer objCustomer)
        {
            //check if Edit then Action
            if (true)
            {

            }
            // if view detaisl 
            if (true)
            {

            }
            else
            {

            }
            return null;

        }

        public bool Delete(long ID)
        {
            bool IsDeleted = false;
            using (FopexEntities1 db = new FopexEntities1())
            {
                try
                {
                    Fopex.DAL.dbxEntities.Customer query = new Fopex.DAL.dbxEntities.Customer();


                    query = db.Customers.Where(c => c.CustID == ID).FirstOrDefault();
                    if (query != null)
                    {
                        db.Customers.Remove(query);
                        db.SaveChanges();
                        IsDeleted = true;
                    }
                }
                catch
                {
                    IsDeleted = false;
                }
                return IsDeleted;
            }


        }



    }
}

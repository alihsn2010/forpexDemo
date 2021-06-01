using Fopex.DAL.Areas.City;
using Fopex.DAL.Areas.Customer;
using Fopex.DAL.Areas.Region;
using Fopex.DAL.Model.City;
using Fopex.DAL.Model.Country;
using Fopex.DAL.Model.Customer;
using Fopex.DAL.Model.Region;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fopex.BAL.Areas.Customer
{
    public class BOCustomer
    {
        #region bind Dropdownlist

        public List<mCity> ddlGetCity()
        {

            DOCity objCity = new DOCity();
            var result = objCity.GetAllActive();

            return result;

        }

        public List<mCountry> ddlGetCountry()
        {

            Fopex.DAL.Areas.Country.DOCountry objDOCountry = new DAL.Areas.Country.DOCountry();
            var result = objDOCountry.GetAllActive();

            return result;

        }

        public List<mRegion> ddlGetRegion()
        {

            DORegion objDORegion = new DORegion();
            var result = objDORegion.GetAllActive();

            return result;

        }

        //public List<mCity> itemtypesDropDown()
        //{
        //    try
        //    {
        //        var mylist = cshparpEntity.itemtypes.ToList();
        //        var fromDatabaseEF = new SelectList(mylist.ToList(), "ID", "Item_Type_Code");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    finally
        //    {

        //    }
        //}




        #endregion


        #region GetAll
        public List<mCustomer> BOGetCustomer()
        {
            try
            {
                List<mCustomer> objModelCustomer = new List<mCustomer>();
                //List<DOCity> dd = new List<DOCity>();
                DOCustomer objCustomer = new DOCustomer();
                objModelCustomer = objCustomer.GetAll();
                if (objModelCustomer.Count > 0)
                {
                    //var json = JsonConvert.SerializeObject(dtResultSet, Formatting.None);
                    //var ReturnResult = JsonConvert.DeserializeObject<List<mCity>>(json);
                    return objModelCustomer;
                }
                else
                {
                    return null;
                }



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }


        public mCustomer BOGetCustomerbyID(long CustomerID)
        {
            try
            {
              
                DOCustomer objCustomer = new DOCustomer();
                mCustomer objModelCustomer = new mCustomer();
                objModelCustomer = objCustomer.GetByID(CustomerID);
                if (objModelCustomer != null)
                {
                    //var json = JsonConvert.SerializeObject(dtResultSet, Formatting.None);
                    //var ReturnResult = JsonConvert.DeserializeObject<List<mCity>>(json);
                    return objModelCustomer;
                }
                else
                {
                    return null;
                }



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }


        #endregion

        #region  Add


        public Int64 BOAddNewCustomer(mCustomer objCust)
        {
            try
            {
                Int64 result = 0;

                mCustomer objModelCustomer = new mCustomer();
                DOCustomer doCustomer = new DOCustomer();
                //DOItem doitem = new DOItem();
                
                if (objCust != null)
                {
                    // create customer  
                    result = doCustomer.Add(objCust);

                    // vendor customer id > plus items from item table 
                    // cust :149 
                    // item get all item  doitem.getitem();
                    

                    // add customer company detail

                    // item detail 
                }

                if (result != null)
                {
                    //var json = JsonConvert.SerializeObject(dtResultSet, Formatting.None);
                    //var ReturnResult = JsonConvert.DeserializeObject<List<mCity>>(json);
                    return result;
                }
                else
                {
                    return 0;
                }



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }

        #endregion

        #region  Update
        public bool BOUpdateCustomer(mCustomer customers)
        {
            try
            {
                bool result = false;
                DOCustomer obj = new DOCustomer();
                if (customers.CustID != null)
                {
                    result = obj.Delete(customers.CustID);
                }
                if (result)
                {
                    //var json = JsonConvert.SerializeObject(dtResultSet, Formatting.None);
                    //var ReturnResult = JsonConvert.DeserializeObject<List<mCity>>(json);
                    return true;
                }
                else
                {
                    return false;
                }



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }




        #endregion

        #region  Delete
        public bool BODeleteCustomer(long CustID)
        {
            try
            {
                bool result = false;
                DOCustomer obj = new DOCustomer();
                if (CustID != null)
                {
                    result = obj.Delete(CustID);
                }
                if (result)
                {
                    //var json = JsonConvert.SerializeObject(dtResultSet, Formatting.None);
                    //var ReturnResult = JsonConvert.DeserializeObject<List<mCity>>(json);
                    return true;
                }
                else
                {
                    return false;
                }



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }

        #endregion
    }
}

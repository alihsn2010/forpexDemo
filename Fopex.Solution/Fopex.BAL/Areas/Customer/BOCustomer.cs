using Fopex.DAL.Areas.Customer;
using Fopex.DAL.Model.City;
using Fopex.DAL.Model.Customer;
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


        #endregion

        #region  Add


        public mCustomer BOAddNewCustomer(mCustomer objCust)
        {
            try
            {

                mCustomer objModelCustomer = new mCustomer();
                DOCustomer doCustomer = new DOCustomer();
                objModelCustomer = doCustomer.AddNewCustomer(objCust);
                if (objModelCustomer.CustID > 0)
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

        #region  Edit

        #endregion

        #region  Delete

        #endregion
    }
}

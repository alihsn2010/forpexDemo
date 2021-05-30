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


        #endregion

        #region  Add


        public Int64 BOAddNewCustomer(mCustomer objCust)
        {
            try
            {
                Int64 result = 0;

                mCustomer objModelCustomer = new mCustomer();
                DOCustomer doCustomer = new DOCustomer();
                if (objCust != null )
                {
                    result = doCustomer.AddNewCustomer(objCust);
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

        #region  Edit

        #endregion

        #region  Delete

        #endregion
    }
}

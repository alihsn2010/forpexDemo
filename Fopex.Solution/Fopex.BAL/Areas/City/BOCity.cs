using Fopex.DAL.Areas.City;
using Fopex.DAL.Model.City;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fopex.BAL.Areas.City
{
    public class BOCity
    {
        #region GetAll
        public List<mCity> GetCity()
        {
            try
            {
                //List<DOCity> dd = new List<DOCity>();
                DOCity objCity = new DOCity();
                var dtResultSet = objCity.GetAllActive();
                if (dtResultSet.Count > 0)
                {
                    var json = JsonConvert.SerializeObject(dtResultSet, Formatting.None);
                    var ReturnResult = JsonConvert.DeserializeObject<List<mCity>>(json);
                    return ReturnResult;
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

        #endregion

        #region  Edit

        #endregion

        #region  Delete

        #endregion

       

    }
}

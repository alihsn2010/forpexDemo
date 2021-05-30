using Fopex.DAL.Areas.Region;
using Fopex.DAL.Model.Region;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fopex.BAL.Areas.Region
{
    public class BORegion
    {

        #region GetAll
        public List<mRegion> GetRegion()
        {
            try
            {
                //List<DOCity> dd = new List<DOCity>();
                DORegion objRegion = new DORegion();
                var dtResultSet = objRegion.GetAllActive();
                if (dtResultSet.Count > 0)
                {
                    var json = JsonConvert.SerializeObject(dtResultSet, Formatting.None);
                    var ReturnResult = JsonConvert.DeserializeObject<List<mRegion>>(json);
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

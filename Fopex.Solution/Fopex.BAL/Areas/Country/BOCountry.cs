
using Fopex.DAL.Areas.Country;
using Fopex.DAL.Model.Country;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Fopex.BAL.Areas.Country
{
    public  class BOCountry
    {
        public List<mCountry> GetCountry()
        {
            try
            {
              
                var dtResultSet = DOTravel.GetCountry();
                if (dtResultSet.Tables[0].Rows.Count > 0)
                {
                    var json = JsonConvert.SerializeObject(dtResultSet.Tables[0], Formatting.None, new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" });
                    var ReturnResult = JsonConvert.DeserializeObject<List<mCountry>>(json);
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







    }
}

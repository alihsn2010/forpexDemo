
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
                DOCountry objDOCountry = new DOCountry();

                var dtResultSet = objDOCountry.GetAllActive();
                return dtResultSet;
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

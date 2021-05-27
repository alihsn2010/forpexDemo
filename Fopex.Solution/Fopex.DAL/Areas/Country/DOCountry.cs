using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Tracer;
using Fopex.COMMON.Helper;

namespace Fopex.DAL.Areas.Country
{
    public class DOTravel
    {
       



       

        public static DataSet GetCountry(string CountryCode = null)
        {

            CountryCode = "PK";
            SqlParameter[] param = { new SqlParameter("@CountryCode", CountryCode) };
            var dt = ExecuteSP("TR_GetCountry_SP", param);
            return dt;
        }

        
        #region DB Calls SP
        public static DataSet ExecuteSP(string spName, params SqlParameter[] parameters)
        {

            return Fopex.DAL.Utility.DBCon.ExecuteSP(spName, Constant.TravelConnection, parameters);
        }
      
        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fopex.DAL.Utility
{
    public class DBCon
    {


        public static DataSet ExecuteSP(string spName, string conString, params SqlParameter[] parameters)
        {
            var ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 0;
                        cmd.CommandText = spName;
                        if (parameters != null)
                        {
                            foreach (SqlParameter param in parameters)
                            {
                                if (param.Value != null)
                                {
                                    if (param.Value.ToString().ToLower() != "null")
                                        if (param.Value.ToString() != "0")
                                            cmd.Parameters.Add(param);
                                        else
                                            cmd.Parameters.Add(param);
                                }
                            }
                        }
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {

                            da.Fill(ds);
                        }
                    }
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}

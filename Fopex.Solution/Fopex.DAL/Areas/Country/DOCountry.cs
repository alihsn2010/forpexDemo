using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Tracer;
using Fopex.COMMON.Helper;
using Fopex.DAL.Model.Country;
using Fopex.DAL.dbxEntities;

namespace Fopex.DAL.Areas.Country
{
    public class DOCountry
    {
        mCountry ModelCountry;
        List<mCountry> CountryList;
        public List<mCountry> GetAllActive()
        {
            CountryList = new List<mCountry>();
            dbxEntities.City objCity = new dbxEntities.City();

            using (FopexEntities1 db = new FopexEntities1())
            {

                try
                {
                    var query = db.Countries.OrderBy(ob => ob.Country_Code).ToList();
                    if (query != null)
                    {
                        foreach (dbxEntities.Country c in query)
                        {
                            mCountry ModelCountry = new mCountry();
                            ModelCountry.ID = c.ID;
                            ModelCountry.Country_Code = c.Country_Code;
                            ModelCountry.Country_Name = c.Country_Name;
                            CountryList.Add(ModelCountry);
                        }
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
                return CountryList;
            }
        }





    }
}

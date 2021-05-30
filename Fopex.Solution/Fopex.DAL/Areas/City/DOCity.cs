using Fopex.DAL.dbxEntities;
using Fopex.DAL.Model.City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fopex.DAL.Areas.City
{
    public class DOCity
    {
        mCity ModelCity;
        List<mCity> CityList;
        public List<mCity> GetAllActive()
        {
            CityList = new List<mCity>();
            dbxEntities.City objCity = new dbxEntities.City();
            using (FopexEntities1 db = new FopexEntities1())
            {

                try
                {
                    var query = db.Cities.OrderBy(ob => ob.City_Name).ToList();
                    if (query != null)
                    {
                        foreach (dbxEntities.City c in query)
                        {
                            ModelCity = new mCity();
                            ModelCity.ID = c.ID;
                            ModelCity.City_Name = c.City_Name;
                            CityList.Add(ModelCity);
                        }
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
                return CityList;
            }
        }

       
    }
}

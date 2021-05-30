using Fopex.DAL.dbxEntities;
using Fopex.DAL.Model.Region;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fopex.DAL.Areas.Region
{
    public class DORegion
    {
       
        public List<mRegion> GetAllActive()
        {
            List<mRegion> RegionList = new List<mRegion>();
            mRegion ModelRegion = new mRegion();
            using (FopexEntities1 db = new FopexEntities1())
            {

                try
                {
                    var query = db.Regions.OrderBy(ob => ob.Region_Code).ToList();
                    if (query != null)
                    {
                        foreach (dbxEntities.Region c in query)
                        {
                            ModelRegion = new mRegion();
                            ModelRegion.ID = c.ID;
                            ModelRegion.Region_Code = c.Region_Code;
                            ModelRegion.Region_Name = c.Region_Name;
                            RegionList.Add(ModelRegion);
                        }
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
                return RegionList;
            }
        }
    }
}

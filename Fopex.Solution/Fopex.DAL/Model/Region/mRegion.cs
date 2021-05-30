using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fopex.DAL.Model.Region
{
    public class mRegion
    {

        public int ID { get; set; }
        public string Region_Name { get; set; }
        public string Region_Code { get; set; }
        public Nullable<int> IsActive { get; set; }
    }
}

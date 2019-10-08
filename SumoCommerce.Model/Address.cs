using SumoCommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.Model
{
    public class Address : BaseEntity
    {
        public string Explanation { get; set; }
        public int CityID { get; set; }
        public int CountyID { get; set; }
        public int UserID { get; set; }

        public virtual County County { get; set; }
        public virtual City City { get; set; }
        public virtual User User { get; set; }
    }
}

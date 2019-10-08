using SumoCommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.Model
{
    public class County : BaseEntity
    {
        public string CountyName { get; set; }
        public int CityID { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual City City { get; set; }
    }
}

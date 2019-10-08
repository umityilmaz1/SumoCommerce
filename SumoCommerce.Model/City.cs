using SumoCommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.Model
{
    public class City : BaseEntity
    {
        public string CityName { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<County> Counties { get; set; }
    }
}

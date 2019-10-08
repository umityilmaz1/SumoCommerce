using SumoCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.DAL.Concrete.EntityFramework.Mappings
{
    class CityMapping : EntityTypeConfiguration<City>
    {
        public CityMapping()
        {
            HasKey(a=>a.ID);

            HasMany(a => a.Counties).WithRequired(a => a.City).HasForeignKey(a => a.CityID).WillCascadeOnDelete(false);
        }
    }
}

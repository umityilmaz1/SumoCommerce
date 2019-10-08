using SumoCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.DAL.Concrete.EntityFramework.Mappings
{
    class AddressMapping : EntityTypeConfiguration<Address>
    {
        public AddressMapping()
        {
            HasKey(a => a.ID);

            HasRequired(a => a.County).
                WithMany(a => a.Addresses).
                HasForeignKey(a => a.CountyID).WillCascadeOnDelete(false);

            HasRequired(a => a.City).
                WithMany(a => a.Addresses).
                HasForeignKey(a => a.CityID);

            HasRequired(a => a.User).
                WithMany(a => a.Address).
                HasForeignKey(a => a.UserID);
        }
    }
}

using SumoCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.DAL.Concrete.EntityFramework.Mappings
{
    class OrderMapping : EntityTypeConfiguration<Order>
    {
        public OrderMapping()
        {
            HasKey(a => a.ID);

            HasRequired(a => a.User).
                WithMany(a => a.Orders)
                .HasForeignKey(a => a.UserID);
        }
    }
}

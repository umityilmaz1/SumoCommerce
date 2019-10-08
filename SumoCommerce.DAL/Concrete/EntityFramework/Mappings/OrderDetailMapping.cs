using SumoCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.DAL.Concrete.EntityFramework.Mappings
{
    class OrderDetailMapping : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMapping()
        {
            HasKey(a => a.ID);

            HasRequired(a => a.Order)
                .WithMany(a => a.OrderDetails)
                .HasForeignKey(a => a.OrderID);

            HasRequired(a => a.Product).WithMany(a => a.OrderDetails).HasForeignKey(a => a.ProductID);
        }
    }
}

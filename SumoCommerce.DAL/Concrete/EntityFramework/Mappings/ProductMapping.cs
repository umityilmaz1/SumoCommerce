using SumoCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.DAL.Concrete.EntityFramework.Mappings
{
    class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            HasKey(a => a.ID);

            HasRequired(a => a.Category)
                .WithMany(a => a.Products).
                HasForeignKey(a => a.CategoryID);

            HasMany(a => a.ShoppingCarts).WithRequired(a => a.Product).HasForeignKey(a=>a.ProductID);

        }
    }
}

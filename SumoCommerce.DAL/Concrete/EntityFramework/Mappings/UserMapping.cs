using SumoCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.DAL.Concrete.EntityFramework.Mappings
{
    class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasKey(a => a.ID);

            HasRequired(a => a.UserRole).
                WithMany(a => a.Users).
                HasForeignKey(a => a.UserRoleID);

            HasMany(a => a.ShoppingCarts).WithRequired(a => a.User).HasForeignKey(a => a.UserID);


            //HasRequired(a => a.ShoppingCart).WithRequiredPrincipal(a => a.User).WillCascadeOnDelete(true); //birebir ilişki mappingi

        }
    }
}

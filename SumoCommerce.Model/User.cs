using SumoCommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.Model
{
    public class User : BaseEntity
    {
        public User()
        {
            //liste tipi ilişkileri hash yapmayı unutma
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public int UserRoleID { get; set; }

        public virtual UserRole UserRole { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }




    }
}

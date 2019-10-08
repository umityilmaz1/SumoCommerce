using SumoCommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoCommerce.Model
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int ShoppingCardID { get; set; }
        public int CategoryID { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection< OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SumoCommerce.UI.MVC.Models
{
    public class ShoppingCartDTO
    {
        public int ShoppingCartID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
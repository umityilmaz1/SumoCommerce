using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SumoCommerce.UI.MVC.Models
{
    public class ShoppingCartModelView
    {
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SumoCommerce.UI.MVC.Models
{
    public class CheckoutViewModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string GsmNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string County { get; set; }
        public string City { get; set; }

        public string CardNumber { get; set; }
        public string CardHolder { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int CVC { get; set; }

        public List<ShoppingCartDTO> ShoppingCartProducts { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SumoCommerce.UI.MVC.Models
{
    public class UserRegistrationViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
        public string PhoneNumber { get; set; }
        public int CityID { get; set; }
        public int CountyID { get; set; }
        public string Address { get; set; }
    }
}
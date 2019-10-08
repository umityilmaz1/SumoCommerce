using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SumoCommerce.UI.MVC.Models
{
    public class RegisterViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public int UserRoleID { get; set; }
        public int CityID { get; set; }
    }
}
using SumoCommerce.BLL.Abstract;
using SumoCommerce.Model;
using SumoCommerce.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SumoCommerce.UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        IUserService _userService;
        IAddressService _addressService;

        public AccountController(IUserService userService, IAddressService addressService)
        {
            _userService = userService;
            _addressService = addressService;
        }

        public ActionResult List()
        {
            return View(_userService.GetList());
        }

        public string Add(UserRegistrationViewModel user)
        {
            if (_userService.GetByFilter(a => a.Mail == user.Email) == null)
            {
                User newUser = new User();
                newUser.Name = user.Name;
                newUser.Surname = user.Surname;
                newUser.Mail = user.Email;
                newUser.Password = user.Password;
                newUser.BirthDate = user.Birthdate;
                newUser.PhoneNumber = user.PhoneNumber;
                newUser.UserRoleID = 2;

                if (_userService.Add(newUser))
                {
                    int userID = _userService.GetByFilter(a => a.Mail == user.Email).ID;

                    Address newAddress = new Address();
                    newAddress.Explanation = user.Address;
                    newAddress.CityID = user.CityID;
                    newAddress.CountyID = user.CountyID;
                    newAddress.UserID = userID;

                    if (_addressService.Add(newAddress))
                    {
                        return "Kaydınız başarıyla oluşturuldu. Giriş sayfasına yönlendiriliyorsunuz.";
                    }

                    return "Kaydınız başarıyla oluşturuldu. Ancak adres bilginiz eklenirken hata olştu. Lütfen daha sonra adres bilginizi güncelleyiniz. Giriş sayfasına yönlendiriliyorsunuz.";
                }

                return "Kaydınız yapılırken bir hata oluştu lütfen yeniden deneyiniz.";
            }

            return "Bu mail adresi daha önce alınmış. Lütfen başka bir mail adresi deneyin.";
        }

        public ActionResult Update(User user)
        {
            return View(_userService.Update(user));
        }
        public ActionResult Delete(int userID)
        {
            return View(_userService.DeleteByID(userID));
        }
        public ActionResult GetByID(int userID)
        {
            return View(_userService.GetByID(userID));
        }

        public bool GetUserByLoginData(LoginViewModel model)
        {
            User currentUser = _userService.GetByLogin(model.Mail, model.Password);

            if (currentUser != null && currentUser.IsActive == true)
            {
                Session["userID"] = currentUser.ID;
                return true;
            }

            return false;
        }


    }
}
using SumoCommerce.BLL.Abstract;
using SumoCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SumoCommerce.UI.MVC.Controllers
{
    public class AddressController : Controller
    {
        IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public ActionResult List()
        {
            return View(_addressService.GetList());
        }
        public ActionResult Add(Address address)
        {
            return View(_addressService.Add(address));
        }
        public ActionResult Update(Address address)
        {
            return View(_addressService.Update(address));
        }
        public ActionResult Delete(int addressID)
        {
            return View(_addressService.DeleteByID(addressID));
        }
        public ActionResult GetByID(int addressID)
        {
            return View(_addressService.GetByID(addressID));
        }
    }
}
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
    public class CityController : Controller
    {
        ICityService _cityService;
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        public ActionResult List()
        {
            return View(_cityService.GetList());
        }

        public JsonResult ListWithDTO() //Bu metoda dokunmayalım
        {
            List<City> cityList = _cityService.GetList();

            List<CityViewModel> cityViewModelList = new List<CityViewModel>();

            foreach (City item in cityList)
            {
                cityViewModelList.Add(new CityViewModel() { ID = item.ID, CityName = item.CityName });
            }

            return Json(cityViewModelList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add(City City)
        {
            return View(_cityService.Add(City));
        }
        public ActionResult Update(City City)
        {
            return View(_cityService.Update(City));
        }
        public ActionResult Delete(int CityID)
        {
            return View(_cityService.DeleteByID(CityID));
        }
        public ActionResult GetByID(int CityID)
        {
            return View(_cityService.GetByID(CityID));
        }
    }
}
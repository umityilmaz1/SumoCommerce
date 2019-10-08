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
    public class CountyController : Controller
    {
        ICountyService _countyService;
        public CountyController(ICountyService countyService)
        {
            _countyService = countyService;
        }

        public ActionResult List()
        {
            return View(_countyService.GetList());
        }

        public JsonResult GetByCityID(int id) //Bu metoda dokunmayalım
        {
            List<County> countyList = _countyService.GetByFilter(a => a.CityID == id);

            List<CountyViewModel> countyViewModelList = new List<CountyViewModel>();

            foreach (County item in countyList)
            {
                countyViewModelList.Add(new CountyViewModel() { ID = item.ID, CountyName = item.CountyName });
            }

            return Json(countyViewModelList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add(County County)
        {
            return View(_countyService.Add(County));
        }
        public ActionResult Update(County County)
        {
            return View(_countyService.Update(County));
        }
        public ActionResult Delete(int CountyID)
        {
            return View(_countyService.DeleteByID(CountyID));
        }
        public ActionResult GetByID(int CountyID)
        {
            return View(_countyService.GetByID(CountyID));
        }
    }
}
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
        public JsonResult GetByCityID(int id)
        {
            List<County> countyList = _countyService.GetListByFilter(a => a.CityID == id);

            List<CountyDTOForRegistration> countyDTOForRegistrationList = new List<CountyDTOForRegistration>();

            foreach (County item in countyList)
            {
                countyDTOForRegistrationList.Add(new CountyDTOForRegistration() { ID = item.ID, CountyName = item.CountyName });
            }

            return Json(countyDTOForRegistrationList, JsonRequestBehavior.AllowGet);
        }

    }
}
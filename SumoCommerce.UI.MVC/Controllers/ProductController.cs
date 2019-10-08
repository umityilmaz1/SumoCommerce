using SumoCommerce.BLL.Abstract;
using SumoCommerce.Model;
using SumoCommerce.UI.MVC.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SumoCommerce.UI.MVC.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public JsonResult List()
        {
            return Json(_productService.GetList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Add(Product product)
        {
            return View(_productService.Add(product));
        }
        public ActionResult Update(Product product)
        {
            return View(_productService.Update(product));
        }
        public ActionResult Delete(int productID)
        {
            return View(_productService.DeleteByID(productID));
        }
        public ActionResult GetByID(int productID)
        {
            return View(_productService.GetByID(productID));
        }
    }
}
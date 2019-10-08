using SumoCommerce.BLL.Abstract;
using SumoCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SumoCommerce.UI.MVC.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ActionResult List()
        {
            return View(_categoryService.GetList());
        }
        public ActionResult Add(Category category)
        {
            return View(_categoryService.Add(category));
        }
        public ActionResult Update(Category category)
        {
            return View(_categoryService.Update(category));
        }
        public ActionResult Delete(int categoryID)
        {
            return View(_categoryService.DeleteByID(categoryID));
        }
        public ActionResult GetByID(int categoryID)
        {
            return View(_categoryService.GetByID(categoryID));
        }

    }
}
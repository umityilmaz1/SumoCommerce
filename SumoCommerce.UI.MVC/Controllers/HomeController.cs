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
    public class HomeController : Controller
    {
        readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            int urunSayisi = _productService.GetList().Count();

            Random rnd = new Random();

            List<Product> randomUrunler = new List<Product>();


            for (int i = 1; i < 10; i++)
            {

                int randomUrunID = rnd.Next(1, urunSayisi);

                randomUrunler.Add(_productService.GetByID(randomUrunID));
            }

            return View(randomUrunler);
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Products(List<Product> productList)
        {
            if (productList == null)
                productList = _productService.GetList();

            return View(productList);
        }


        public ActionResult ProductDetail(int id)
        {
            Product proc = _productService.GetByID(id);
            return View(proc);
        }

        public ActionResult Checkout()
        {
            return View();
        }

        

    }
}
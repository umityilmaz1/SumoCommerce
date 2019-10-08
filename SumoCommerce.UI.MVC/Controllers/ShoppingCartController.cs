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
    public class ShoppingCartController : Controller
    {
        IShoppingCartService _shoppingCartService;
        IUserService _userService;
        IProductService _productService;
        public ShoppingCartController(IShoppingCartService shoppingCartService,IUserService userService,IProductService productService)
        {
            _shoppingCartService = shoppingCartService;
            _userService = userService;
            _productService = productService;
        }

        public ActionResult List()
        {
            return View(_shoppingCartService.GetList());
        }
        public bool Add(ShoppingCartModelView ShoppingCart) //Bu metodu bozmayalım
        {
            ShoppingCart newShoppingCart = new ShoppingCart();
            newShoppingCart.UserID = ShoppingCart.UserID;
            newShoppingCart.ProductID = ShoppingCart.ProductID;
            newShoppingCart.Quantity = ShoppingCart.Quantity;

            ShoppingCart existShoppingCart = _shoppingCartService.GetByFilter(a => a.UserID == newShoppingCart.UserID & a.ProductID == newShoppingCart.ProductID);

            if (existShoppingCart == null)
            {
                if (_shoppingCartService.Add(newShoppingCart))
                    return true;

                return false;
            }
            else {
                existShoppingCart.Quantity += newShoppingCart.Quantity;

                if (_shoppingCartService.Update(existShoppingCart))
                {
                    return true;
                }

                return false;
            }
        }
        public ActionResult Update(ShoppingCart ShoppingCart)
        {
            return View(_shoppingCartService.Update(ShoppingCart));
        }
        public ActionResult Delete(int ShoppingCartID)
        {
            return View(_shoppingCartService.DeleteByID(ShoppingCartID));
        }
        public ActionResult GetByID(int ShoppingCartID)
        {
            return View(_shoppingCartService.GetByID(ShoppingCartID));
        }



        //public JsonResult GetAllByUserID(CheckoutViewModel checkoutModel)
        //{
        //    List<ShoppingCart> shoppingCart = _shoppingCartService.GetListByFilter(a=>a.ID== checkoutModel.UserID);
        //    User currentUser = _userService.GetByFilter(a=>a.ID==(int)Session["userID"]);
        //    List<Product> productList = _productService.GetList();
        //    CheckoutViewModel checkoutViewModel = new CheckoutViewModel();


        //    checkoutViewModel.UserID = currentUser.ID;
        //    checkoutViewModel.UserName = currentUser.Name;
        //    checkoutViewModel.UserSurname = currentUser.Surname;
        //    checkoutViewModel.GsmNumber = currentUser.PhoneNumber;
        //    checkoutViewModel.Email = currentUser.Mail;
        //    checkoutViewModel.Address = (currentUser.Address as List<Address>)[0].Explanation;
        //    checkoutViewModel.County= (currentUser.Address as List<Address>)[0].County.CountyName;
        //    checkoutViewModel.City = (currentUser.Address as List<Address>)[0].City.CityName;
        //    checkoutViewModel.CardNumber = checkoutModel.CardNumber;
        //    checkoutViewModel.CardHolder = checkoutModel.CardHolder;
        //    checkoutViewModel.Month = checkoutModel.Month;
        //    checkoutViewModel.Year = checkoutModel.Year;
        //    checkoutViewModel.CVC = checkoutViewModel.CVC;

        //    foreach (ShoppingCartDTO item in checkoutModel.ShoppingCartProducts)
        //    {
        //        checkoutViewModel.ShoppingCartProducts.Add(new ShoppingCartDTO()
        //        {
        //            ShoppingCartID = item.ShoppingCartID,
        //            Name = item.Name,
        //            Category=item.Category,


        //        }) ;
                
        //    }

            
        //}
    }
}
using SumoCommerce.BLL.Abstract;
using SumoCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SumoCommerce.UI.MVC.Controllers
{
    public class OrderController : Controller
    {
        IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public ActionResult List()
        {
            return View(_orderService.GetList());
        }
        public ActionResult Add(Order order)
        {
            return View(_orderService.Add(order));
        }
        public ActionResult Update(Order order)
        {
            return View(_orderService.Update(order));
        }
        public ActionResult Delete(int orderID)
        {
            return View(_orderService.DeleteByID(orderID));
        }
        public ActionResult GetByID(int orderID)
        {
            return View(_orderService.GetByID(orderID));
        }
    }
}
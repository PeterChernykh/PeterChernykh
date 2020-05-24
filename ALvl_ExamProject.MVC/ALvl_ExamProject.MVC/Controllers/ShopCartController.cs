using ALvl_ExamProject.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALvl_ExamProject.MVC.Controllers
{
    public class ShopCartController : Controller
    {
        // GET: ShopCart
        public ActionResult Index()
        {
            var cart = Session["cart"] as List<ShopCartPL> ?? new List<ShopCartPL>();

            if(cart.Count() == 0|| Session["cart"] == null)
            {
                ViewBag.Message = "Cart is empty!";
                return View();
            }
            decimal total = 0m;

            foreach (var item in cart)
            {
                total += item.Total;
            }

            ViewBag.TotalAmount = total;

            return View();
        }

        public ActionResult CartPartial()
        {
            ShopCartPL cart = new ShopCartPL();

            int quantity = 0;

            decimal price = 0m;

            if (Session["Cart"] != null)
            {
                var list = (List <ShopCartPL>) Session["Cart"];

                foreach (var item in list)
                {
                    quantity += item.Quantity;
                    price += item.Quantity * item.Price;
                }
            }
            else
            {
                cart.Quantity = 0;
                cart.Price = 0m;
            }

            return PartialView("_CartPartial", cart);
        }
    }
}
using ALvl_ExamProject.BL.Interfaces;
using ALvl_ExamProject.BL.Models;
using ALvl_ExamProject.MVC.Models;
using AutoMapper;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace ALvl_ExamProject.MVC.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IOrderService _orderService;

        public ShopCartController(IProductService productService, IMapper mapper, IOrderDetailService orderDetailService, IOrderService orderService)
        {
            _orderDetailService = orderDetailService;
            _productService = productService;
            _mapper = mapper;
            _orderService = orderService;
        }

        // GET: ShopCart
        public ActionResult Index()
        {
            var cart = Session["cart"] as List<ShopCartPL> ?? new List<ShopCartPL>();

            if (cart.Count() == 0 || Session["cart"] == null)
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

            return View(cart);
        }

        public ActionResult CartPartial()
        {
            ShopCartPL cart = new ShopCartPL();

            int quantity = 0;

            decimal price = 0m;

            if (Session["Cart"] != null)
            {
                var list = (List<ShopCartPL>)Session["Cart"];

                foreach (var item in list)
                {
                    quantity += item.Quantity;
                    price += item.Quantity * item.Price;
                }
                cart.Quantity = quantity;
                cart.Price = price;

            }
            else
            {
                cart.Quantity = 0;
                cart.Price = 0m;
            }

            return PartialView("_CartPartial", cart);
        }

        public ActionResult AddToCartPartial(int id)
        {
            List<ShopCartPL> cart = Session["cart"] as List<ShopCartPL> ?? new List<ShopCartPL>();

            ShopCartPL cartPL = new ShopCartPL();

            var productBL = _productService.GetById(id);

            var productPL = _mapper.Map<ProductPL>(productBL);

            var productInCart = cart.FirstOrDefault(x => x.ProductPL.Id == id);

            if (productInCart == null)
            {
                cart.Add(new ShopCartPL()
                {
                    ProductPL = productPL,
                    Quantity = 1,
                    Price = productPL.Price,
                    ImagePath = productPL.ImagePath
                });
            }

            else
            {
                productInCart.Quantity++;
            }

            int amount = 0;
            decimal price = 0m;

            foreach (var item in cart)
            {
                amount += item.Quantity;
                price += item.Quantity * item.Price;
            }

            cartPL.Quantity = amount;
            cartPL.Price = price;

            Session["cart"] = cart;

            return PartialView("_AddToCartPartial", cartPL);
        }

        //GET: /shopcart/AddProductToShopCart
        [HttpGet]
        public JsonResult AddProductToShopCart(int prodId)
        {
            List<ShopCartPL> carts = Session["cart"] as List<ShopCartPL>;

            ShopCartPL cart = carts.FirstOrDefault(x => x.ProductPL.Id == prodId);

            cart.Quantity++;

            var result = new { qty = cart.Quantity, price = cart.Price };

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        //GET: /shopcart/RemoveProductFromShopCart
        [HttpGet]
        public ActionResult RemoveProductFromShopCart(int prodId)
        {
            List<ShopCartPL> carts = Session["cart"] as List<ShopCartPL>;

            ShopCartPL cart = carts.FirstOrDefault(x => x.ProductPL.Id == prodId);
            if (cart.Quantity > 1)
            {
                cart.Quantity--;
            }
            else
            {
                cart.Quantity = 0;
                carts.Remove(cart);
            }

            var result = new { qty = cart.Quantity, price = cart.Price };

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public void RemoveProduct(int prodId)
        {
            List<ShopCartPL> carts = Session["cart"] as List<ShopCartPL>;

            ShopCartPL cart = carts.FirstOrDefault(x => x.ProductPL.Id == prodId);

            carts.Remove(cart);

        }

        public ActionResult PayPalPartial()
        {
            List<ShopCartPL> cart = Session["cart"] as List<ShopCartPL>;

            return PartialView("_PaypalPartial", cart);
        }

        //POST: /shopcart/CreateOrder
        [HttpPost]
        public void CreateOrder()
        {
            List<ShopCartPL> cart = Session["cart"] as List<ShopCartPL>;

            string userId = User.Identity.GetUserId();

            OrderPL orderPL = new OrderPL()
            {
                UserId = userId,
                OrderDate = DateTime.Now
            };

            var orderBL = _mapper.Map<OrderBL>(orderPL);

            _orderService.Add(orderBL);

            var ordersBL = _orderService.GetAll().OrderByDescending(x=>x.OrderDate);
            orderBL = ordersBL.FirstOrDefault(x => x.UserId == orderPL.UserId);

            int orderId = orderBL.Id;

            OrderDetailPL orderDetails = new OrderDetailPL();

            foreach (var item in cart)
            {
                orderDetails.OrderId = orderId;
                orderDetails.UserId = userId;
                orderDetails.ProductId = item.ProductPL.Id;
                orderDetails.Amount = item.Quantity;

                var orderDetailsBL = _mapper.Map<OrderDetailBL>(orderDetails);

                _orderDetailService.Add(orderDetailsBL);
            }

            var client = new SmtpClient("smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("0b3a671368563c", "d0a9df37ab2bb0"),
                EnableSsl = true
            };
            client.Send("shop@example.com", "admin@example.com", "New order received", $"You have a new order.Order number: {orderId}");

            Session["cart"] = null;
        }
    }
}
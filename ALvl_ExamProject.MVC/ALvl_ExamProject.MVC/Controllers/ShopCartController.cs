using ALvl_ExamProject.BL.Interfaces;
using ALvl_ExamProject.MVC.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALvl_ExamProject.MVC.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ShopCartController()
        {

        }

        public ShopCartController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

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

            return View(cart);
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
            List <ShopCartPL> cart = Session["cart"] as List<ShopCartPL> ?? new List<ShopCartPL>();

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
        public JsonResult AddProductToShopCart(int prodId)
        {
            List<ShopCartPL> carts = Session["cart"] as List<ShopCartPL>;

            ShopCartPL cart = carts.FirstOrDefault(x => x.ProductPL.Id == prodId);

            cart.Quantity++;

            var result = new { qty = cart.Quantity, price = cart.Price };

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        //GET: /shopcart/RemoveProductFromShopCart
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
    }
}
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vegan.Database;

namespace Vegan.Web.Controllers
{
    public class ECommerceController : Controller
    {
        private MyDatabase dbContext => HttpContext.GetOwinContext().Get<MyDatabase>();

        public ActionResult Cart()
        {
            var cart = CreateOrGetCart();

            return View(cart);
        }

        private Cart CreateOrGetCart()
        {
            var cart = Session["Cart"] as Cart;
            if (cart == null)
            {
                cart = new Cart();
                SaveCart(cart);
            }

            return cart;
        }

        private void SaveCart(Cart cart)
        {
            Session["Cart"] = cart;
        }
    }
}
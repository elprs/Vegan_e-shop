using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vegan.Database;
using Vegan.Entities.Home;
using Vegan.Services;
using Vegan.Web.Models;

namespace Vegan.Web.Controllers
{
    public class AllProductController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new MyDatabase());

        // GET: AllProduct
        public ActionResult IndexUser()
        {
            AllProductViewModel allProductVM = new AllProductViewModel();

            allProductVM.HomeProducts = unitOfWork.Homes.GetAll();
            
            //TODO for the other 3 categories


            return View(allProductVM);
        }
    }
}
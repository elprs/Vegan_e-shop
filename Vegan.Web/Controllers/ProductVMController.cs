//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using Vegan.Database;
//using Vegan.Services;
//using Vegan.Entities.ViewModels;


//namespace Vegan.Web.Controllers
//{
//    public class ProductVMController : Controller
//    {
//        //// GET: Care
//        //// [Authorize(Roles = "Admins, Supervisors")]
//        //public ActionResult Index()
//        //{
//        //    return View(unitOfWork.Homes.GetAll());
//        //}


//        private UnitOfWork unitOfWork = new UnitOfWork(new MyDatabase());

//        // GET: ProductVM
//        public ActionResult IndexUser()
//        {
//            var homeProducts = unitOfWork.Homes.GetAll();
//            var foodHerbProducts = unitOfWork.FoodHerbs.GetAll();
//            var careProducts = unitOfWork.Cares.GetAll();
//            var supplementProducts = unitOfWork.Supplements.GetAll();

//            var productVMs= new ProductVM(homeProducts.ToList()/*, foodHerbProducts, careProducts, supplementProducts*/)
//            {
//                HomeProducts = homeProducts.ToList() //,
//                //FoodHerbProducts = foodHerbProducts,
//                //CareProducts = careProducts,
//                //SupplementProducts = supplementProducts
//            };

//            //IEnumerable < ProductVM > p = productVMs.

//            return View(productVMs);
//        }
//    }
//}



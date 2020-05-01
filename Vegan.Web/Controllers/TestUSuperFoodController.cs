using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vegan.Database;
using Vegan.Entities;
using Vegan.Services;
using System.ComponentModel.DataAnnotations;
using Vegan.Entities.Supplement;

namespace Vegan.Web.Controllers.TestControllers
{
    public class SuperFoodController : Controller
    {
        //===================================== Fields =====================================================================
        private UnitOfWork<MyDatabase> unitOfWork = new UnitOfWork<MyDatabase>();
        private GenericRepository<SuperFood> repository;

        //===================================== Constructor ================================================================
        public SuperFoodController()
        {
            repository = new GenericRepository<SuperFood>(unitOfWork);
        }

        //===================================== Methods ====================================================================
        [HttpGet]
        public ActionResult Index()
        {
            var products = repository.GetAll();
            return View(products);
        }

        [HttpGet]
        public ActionResult AddSuperFood()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSuperFood(SuperFood model)
        {
            try
            {
                unitOfWork.CreateTransaction();
                if (ModelState.IsValid)
                {
                    repository.Insert(model);
                    unitOfWork.Save();
                    //Do Some Other Task with the Database
                    //If everything is working then commit the transaction else rollback the transaction
                    unitOfWork.Commit();
                    return RedirectToAction("Index", "SuperFood");
                }
            }
            catch (Exception ex)
            {
                //Log the exception and rollback the transaction
                unitOfWork.Rollback();
            }
            return View();
        }

        public ActionResult DetailsSuperFood(int productId)
        {
            SuperFood productModel = repository.GetByID(productId);
            return View(productModel);
        }

        [HttpGet]
        public ActionResult EditSuperFood(int productId)
        {
            SuperFood productModel = repository.GetByID(productId);
            return View(productModel);
        }

        [HttpPost]
        public ActionResult EditSuperFood(SuperFood model)
        {
            if (ModelState.IsValid)
            {
                repository.Update(model);
                unitOfWork.Save();
                return RedirectToAction("Index", "SuperFood");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult DeleteSuperFood(int productId)
        {
            SuperFood product = repository.GetByID(productId);
            return View(product);
        }

        [HttpPost, ActionName("DeleteSuperFood")]
        public ActionResult Delete(int productId)
        {
            SuperFood product = repository.GetByID(productId);
            repository.Delete(product);
            unitOfWork.Save();
            return RedirectToAction("Index", "SuperFood");
        }
    }
}
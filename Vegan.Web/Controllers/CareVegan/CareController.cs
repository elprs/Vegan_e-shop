﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vegan.Database;
using Vegan.Entities.Care;
using Vegan.Services;

namespace Vegan.Web.Controllers.CareVegan
{
    public class CareController : Controller
    {

        //===================================== Fields =====================================================================
        private UnitOfWork unitOfWork = new UnitOfWork(new MyDatabase());

        // GET: Care
        public ActionResult Index()
        {
            return View( unitOfWork.Cares.GetAll());
        }

        public ActionResult Details(int productId)
        {
            return View(unitOfWork.Cares.GetById(productId));
        }

        [HttpGet]
        public ActionResult Edit(int productId)
        {
            return View(unitOfWork.Cares.GetById(productId));
        }

        [HttpPost]
        public ActionResult Edit(Care model)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Cares.Edit(model);
                unitOfWork.Complete();
                unitOfWork.Dispose();
                return RedirectToAction("Index", "EssentialOil");
            }
            else
            {
                return View(model);
            }
        }
    }
}
using Microsoft.Ajax.Utilities;
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
using PagedList.Mvc;
using PagedList;

namespace Vegan.Web.Controllers
{
    public class AllProductController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new MyDatabase());

        // GET: AllProduct
        public ActionResult IndexUser(string sortOrder, string searchTitle, int? searchminPrice, int? searchmaxPrice, int? page, int? pSize)
        {

            ViewBag.CurrentTitle = searchTitle;
            ViewBag.CurrentMinPrice = searchminPrice;
            ViewBag.CurrentMaxPrice = searchmaxPrice;
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentpageSize = pSize;



            //Viebag that holds the sorting
            ViewBag.TitleSortParam = String.IsNullOrWhiteSpace(sortOrder) ? "TitleDesc" : "";
            ViewBag.PriceSortParam = sortOrder == "PriceAsc" ? "PriceDesc" : "PriceAsc";

            AllProductViewModel allProductVM = new AllProductViewModel();

            //Get all the eshop categories
            var homes = unitOfWork.Homes.GetAll();

            //Sorting by title & price
            switch (sortOrder)
            {
                case "TitleDesc": homes = homes.OrderByDescending(x => x.Title).ThenBy(x => x.Price); break;
                case "TitleAsc": homes = homes.OrderBy(x => x.Title).ThenBy(x => x.Price); break;
                case "PriceDesc": homes = homes.OrderByDescending(x => x.Price); break;
                case "PriceAsc": homes = homes.OrderBy(x => x.Price).ThenBy(x => x.Title); break;
                default: homes = homes.OrderBy(x => x.Title).ThenBy(x => x.Price); break;
            }
            // Sorting page number
            int pageSize = pSize ?? 3;
            int pageNumber = page ?? 1;


            //======================FILTERS===============================
            //Filtering  Title
            if (!string.IsNullOrWhiteSpace(searchTitle))
            {
                homes = homes.Where(x => x.Title.ToUpper().Contains(searchTitle.ToUpper()));
            }
            //Filtering  Price
            //Filtering  Minimum
            if (!(searchminPrice is null)) 
            {
                homes = homes.Where(x => x.Price >= searchminPrice);
            }
            //Filtering  Maximum
            if (!(searchmaxPrice is null)) 
            {
                homes = homes.Where(x => x.Price <= searchmaxPrice);
            }

            allProductVM.HomeProducts = homes.ToPagedList(pageNumber, pageSize);
            //homes = homes.OrderBy(x => x.Title).ThenBy(x => x.Price);
            //allProductVM.HomeProducts
            //TODO Xreiazetai kapou Dispose??? 

            //TODO for the other 3 categories


            //    return View(homes.ToPagedList(pageNumber, pageSize));

            return View(allProductVM);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vegan.Entities.Home;
using Vegan.Entities.FoodHerb;
using Vegan.Entities.Care;
using Vegan.Entities.Supplement;
using Vegan.Services.HomeRepository;
using Vegan.Database;
using Vegan.Services;

namespace Vegan.Web.Models
{
    public class AllProductViewModel
    {

        // ================================ Properties =========================================
        public List<Home> HomeProducts { get; set; }
        public List<Candle> CandleProducts { get; set; }
        //public IEnumerable<FoodHerb> FoodHerbProducts { get; set; }
        //public IEnumerable<Care> CareProducts { get; set; }
        //public IEnumerable<Supplement> SupplementProducts { get; set; }



        // ================================ Constructors =======================================

        public AllProductViewModel()
        {
             UnitOfWork unitOfWork = new UnitOfWork(new MyDatabase());
             HomeProducts = unitOfWork.Homes.GetAll().ToList();
             CandleProducts = unitOfWork.Candles.GetAll().ToList();

        }

    }

}

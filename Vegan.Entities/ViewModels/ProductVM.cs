using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegan.Entities.ViewModels
{

    public class ProductVM
    {
        // ================================ Properties =========================================
        public IEnumerable<Home.Home> HomeProducts { get; set; }
        public IEnumerable<FoodHerb.FoodHerb> FoodHerbProducts { get; set; }
        public IEnumerable<Care.Care> CareProducts { get; set; }
        public IEnumerable<Supplement.Supplement> SupplementProducts { get; set; }



        //    // ================================ Constructors =======================================
        public ProductVM()
        {

        }

        public ProductVM(IEnumerable<Home.Home> homeProducts1, IEnumerable<FoodHerb.FoodHerb> foodHerbProducts1, IEnumerable<Care.Care> careProducts, IEnumerable<Supplement.Supplement> supplementProducts)
        {
            HomeProducts = homeProducts1;
            FoodHerbProducts = foodHerbProducts1;
            CareProducts = careProducts;
            SupplementProducts = supplementProducts;
        } 
    
    }
}

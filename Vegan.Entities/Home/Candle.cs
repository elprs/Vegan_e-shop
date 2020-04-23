using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegan.Entities.Home
{
    class Candle : IProduct
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        //public string ImageURL { get; set; }
        //public string Description { get; set; }
        //public string Why { get; set; }
        //public string Size { get; set; } //eg 5x3"
        //public string BurnTime { get; set; } //58-59 hours
        //public string Instructions { get; set; }
        //public bool Availability { get; set; }

        //TODO: Add Review 

        //Layout: https://www.the-apothecary.ca/5x3-beeswax-candle

    }
}

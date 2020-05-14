using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegan.Entities.DomainClasses.ECommerce
{
    public class Shipping
    {
        //=================================== Properties ===================================================================
        public string Country { get; }
        public decimal ShippingFare { get; }

        //=================================== Constructor ==================================================================
        public Shipping(string country)
        {
            Country = country;
            ShippingFare = ShippingFareCalc();
        }

        //=================================== Methods ======================================================================
        protected decimal ShippingFareCalc()
        {
            if (Country == "Greece") return 3m;
            else return 5m;
        }

    }
}

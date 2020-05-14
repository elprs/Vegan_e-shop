using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegan.Entities.DomainClasses.ECommerce
{
    class Cart
    {
        //=================================== Properties ===================================================================
        public List<CartItem> CartItems { get; set; }

        //=================================== Constructor ==================================================================
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegan.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime StampTime { get; set; }

        //Navigation property - Relationship with product
        public virtual ICollection<Product> Products { get; set; }

    }
}

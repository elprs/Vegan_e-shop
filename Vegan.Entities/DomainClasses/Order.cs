using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vegan.Entities.Library;

namespace Vegan.Entities
{
    public class Order
    {
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }
        [Display(Name = "Order stamp")]
        public DateTime OrderStamp { get; set; }

        public class Item
        {
            public Product Product { get; set; }
            public int Quantity { get; set; }
        }
        public IEnumerable<Item> Items { get; set; }

        public ApplicationUser User { get; set; }


        //======== Navigation Property  Relationships with
        // Product -->  many
        public virtual ICollection<Product> Products { get; set; }

        // ============================================== Constructor ===========================================
        public Order(DateTime orderStamp, IEnumerable<Item> items, ICollection<Product> products, ApplicationUser user)
        {
            this.OrderStamp = orderStamp;
            this.Items = items;
            this.Products = products;
            this.User = user;


        }
       // ============================================== Methods ===============================================
       public void AddOrderItem(Item item)
        {
            //code
        }

        public void SetAddress(ApplicationUser user)
        {
            //code
        }

        public decimal CalculateTotal(IEnumerable<Item> items)
        {
            //code
            return;
        }


    }
}

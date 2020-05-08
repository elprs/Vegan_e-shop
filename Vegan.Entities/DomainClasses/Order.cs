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
        public DateTime OrderStamp { get; set; } //that is the dateTime that will be created on submit

        //========================= Navigation Properties ======================================================

        //Plan A ===========> // Keeping the class in this form, means that from the server, on sumbit, we send to the db a list of products. In other words, this instanse recieves a list of products. In case a product has quantity > 1, it will be rewritten in the list for as many times as the quantity and this logic needs to be at the cart before the sumbit event.
        public virtual ICollection<Product> Products { get; set; }
        [Display(Name = "Your account")]
        public virtual ApplicationUser User { get; set; }

        // ============================================== Constructor ==========================================
        public Order(DateTime orderStamp, ICollection<Product> products, ApplicationUser user)
        {
            this.OrderStamp = orderStamp;
            this.Products = products;
            this.User = user;
        }

       // ============================================== Methods ===============================================

        //Returns the user's delivery details as a string
        public string SetDeliveryDetails(ApplicationUser user)
        {
            return string.Concat("Name :", user.UserName, "Full Address: ", user.Address, "Phone number: ", user.PhoneNumber);
        }

        //Calculates the total price of the Order
        public decimal CalculateTotal(IEnumerable<Product> products)
        {
            decimal totalPrice = products.Sum(product => product.Price);
            return totalPrice;
        }


        //Plan B ===> create a class named Item that holds the quantity of each added to the cart product and send to the Order Items and not Products

        //public class Item
        //{
        //    public Product Product { get; set; }
        //    public int Quantity { get; set; }
        //}


        //public void AddOrderProduct(Product product)
        //{
        //    //code
        //}
    }
}

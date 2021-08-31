using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }

        public List<ShoppingCartItem> items { get; set; } = new List<ShoppingCartItem>();

        public ShoppingCart()
        {

        }

        public ShoppingCart(string name)
        {
            UserName = name;
        }

        public decimal TotalPrice
        {
            get {
                decimal totalPrice = 0;
                foreach (var item in items) 
                {
                    totalPrice += item.Price * item.Quantity;
                    
                }

                return totalPrice;
            }
        }
    }
}

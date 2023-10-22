using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(Product product, int quantity) 
        {
            Price = product != null? product.Price : 0;
            Quantity = quantity;
        }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set;}

        public decimal Total() 
        {
            return Price * Quantity;
        }


    }
}

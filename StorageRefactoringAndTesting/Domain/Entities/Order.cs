using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        public Order(Customer customer, decimal deliveryFree, Discount discount) 
        {
            Custumer = customer;
            Date = DateTime.Now;
            Number = Guid.NewGuid().ToString().Substring(0,8);
            Status = EOrderStatus.EsperandoPagamento;
            DeliveryFree = deliveryFree;
            Discount = discount;
            Items = new List<OrderItem>();

        }


        public Customer Custumer { get; private set; }
        public DateTime Date { get; private set; }
        public string Number { get; private set; }
        public EOrderStatus Status { get; private set; }
        public IList<OrderItem> Items { get; private set; }
        public Discount Discount { get; private set; }  
        public decimal DeliveryFree { get; private set;}

        public void AddItem(Product product, int quantity) 
        {
            var item = new OrderItem(product, quantity);
            Items.Add(item);    
        }

        public Decimal Total() 
        {
            decimal total = 0;
            foreach (var item in Items) 
            {
                total += item.Total();
            }
            return total;
        }
        public void Pay(decimal amount)
        {
            if (amount == Total()) 
            {
                Status = EOrderStatus.EsperandoEntrega;
            }
        }

        public void Cancel() 
        {
            Status = EOrderStatus.Cancelado;
        }
    }
}

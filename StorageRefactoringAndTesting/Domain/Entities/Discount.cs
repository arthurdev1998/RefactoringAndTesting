using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Discount
    {
        public decimal amount { get; private set; }
        public DateTime ExpireDate { get; private set; }

        public Discount(decimal amount, DateTime expireDate) 
        {
            this.amount = amount;
            this.ExpireDate = expireDate;
        }

        public bool IsValid() 
        {
            return DateTime.Compare(DateTime.Now, ExpireDate) < 0;
        }

        public decimal Value() 
        {
            if (IsValid()) 
            {
                return amount;
            }
            else
            {
                return 0;
            }
        }
    }
}

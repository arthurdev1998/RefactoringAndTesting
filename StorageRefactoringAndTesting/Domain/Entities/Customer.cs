using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string name, string email) 
        {
            this.Name = name;
            this.Email = email;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}

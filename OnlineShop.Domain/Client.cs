using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain
{
    public class Client
    {
        public Client()
        {
            Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

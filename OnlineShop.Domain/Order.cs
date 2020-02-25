using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain
{
    public class Order
    {
        public Order()
        {
            Items = new HashSet<OrderItem>();
        }
        public int Id { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public virtual ICollection<OrderItem> Items { get; set; }
    }
}

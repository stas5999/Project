using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain
{
    public class Item
    {
        public Item()
        {
            Orders = new HashSet<OrderItem>();
        }
        public int Id { get; set; }
        public virtual ICollection<OrderItem> Orders { get; set; }
    }
}

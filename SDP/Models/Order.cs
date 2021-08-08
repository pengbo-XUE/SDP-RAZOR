using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDP.Models
{
    public class Order
    {
        public Guid ID { get; set; }
        public Customer customer{ get; set; }
        public List<OrderLine> OLList;

        public Delivery delivery;

        public Order(Customer customer)
        {
            ID = new Guid();
            this.customer = customer;
        }
    }
}

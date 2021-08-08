using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDP.Models
{
    //customer base class
    [Serializable]
    public abstract class Customer
    {
        public  Guid ID { get; set; }
        public  Cart cart { get; set; }
        public  List<Order> orderList;

        public virtual bool payment() => false;
    }
}

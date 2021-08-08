using SDP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDP.Models
{
    public class RegisteredCustomer :  Customer, IUser
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        
        public RegisteredCustomer() 
        {
            this.orderList = new List<Order>();
            ID = new Guid();
            cart = new Cart(this);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDP.Models
{
    
    public class Cart
    {
        private List<Product> cartList = new List<Product>();
        
        public Customer customer { get; set; }

        //turns the cartLIst into an Order obj with orderline embeded
        private Order turnCartToOrder() 
        {
            Order o = new Order(this.customer);
            foreach (Product p in cartList)
            {
                foreach (OrderLine ol in o.OLList)
                {
                    if (ol.getProduct().Equals(p))
                    {
                        ol.quantity++;
                    }
                }
                OrderLine temp = new OrderLine(o, p, 1, null);
                o.OLList.Add(temp);
            }
            addOrderToCustomerList(o);
            return o;
        }
        public void addOrderToCustomerList(Order order) => order.customer.orderList.Add(order);
        public void addToCart(Product p) => cartList.Add(p);
        public Cart(Customer c) => this.customer = c;
    }
}

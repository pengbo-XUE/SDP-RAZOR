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

        public Cart(Customer c) => this.customer = c;
        public void addOrderToCustomerList(Order order) => order.customer.orderList.Add(order);
        public void addToCart(Product p) => cartList.Add(p);

        //turns the cartLIst into an Order obj with orderline embeded
        public Order turnCartToOrder() 
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

        public void checkOut() 
        {
            if (customer.payment()) 
            {
                /* turnCartToOrder().delivery = new Delivery("DATA NEEDED HERE");*/
            }

        }

    }
}

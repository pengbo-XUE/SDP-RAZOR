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
        private void addOrderToCustomerList(Order order) => order.customer.orderList.Add(order);
        public void addToCart(Product p) => cartList.Add(p);
        public List<Product> getCartList() { return cartList; }

        //turns the cartLIst into an Order obj with orderline embeded
        public Order turnCartToOrder()
        {
            if(cartList.Any())
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
            return null;
        }

        public async Task checkOut() 
        {
            await customer.payment("bank info");
            /* turnCartToOrder().delivery = new Delivery("DATA BROWSER NEEDED HERE");*/
        }

    }

}


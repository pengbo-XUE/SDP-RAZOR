using SDP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDP.Models
{
    public class OrderLine
    {
        public Guid ID = new Guid();
        private Order order;
        private Product product;
        public int quantity { get; set; }
        public IPromotion promotion;

        public OrderLine(Order order, Product product, int quantity, IPromotion promotion)
        {
            this.order = order;
            this.product = product;
            this.quantity = quantity;
            this.promotion = promotion;
        }

        public Order getOrder() => this.order;
        public Product getProduct() => this.product;
    }
}

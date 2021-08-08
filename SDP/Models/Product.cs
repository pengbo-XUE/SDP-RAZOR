using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDP.Models
{
    //this is the product model.... duh...
    [Serializable]
    public class Product
    {
        public Product( string name, decimal price, bool onSpecial, 
            string imgSrc, Consts.type pType,
            double size, string brand, string discription)
        {
            ID  = new Guid();
            this.name = name;
            this.price = price;
            this.onSpecial = onSpecial;
            this.imgSrc = imgSrc;
            this.pType = pType;
            this.size = size;
            this.brand = brand;
            this.discription = discription;
        }

        public Guid ID { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public bool onSpecial { get; set; }  
        public string imgSrc { get; set; }
        public Consts.type pType { get; set; }
        public double size { get; set; }
        public string brand { get; set; }
        public string discription { get; set; }
    }
  
}

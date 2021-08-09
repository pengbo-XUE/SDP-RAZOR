using SDP.Interfaces;
using SDP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDP
{
    //replace data access class when ready
    public static class MockDB
    {
        public static List<Product> MockProductDB = new List<Product>();
        public static List<IUser> MockUserDB = new List<IUser>();
        static List<Tuple<Product, int>> stock;

        public static void popStock() 
        {
            foreach (Product p in MockDB.MockProductDB) 
            {
                stock.Add(new Tuple<Product, int> (p,100));
            }

            
        }

        public static int findStock(Product p) 
        {
            foreach (Tuple<Product, int> t in stock) 
            {
                if (t.Item1 == p) return t.Item2;
            }
            return 0;
        }
    }
}

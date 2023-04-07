using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_shop
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }  
        public string Desc { get; set; }
        public int Amount { get; set; } = 0;
        public Product (string name, double price, string desc)
        {
            Name = name;
            Price = price;
            Desc = desc;
        }

    }
}

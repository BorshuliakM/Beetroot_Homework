using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_shop
{
    public class Order
    {
        public Buyer Buyer { get; set; }
        public List<Product> Products { get; set; }

        public Order(Buyer buyer)
        {
            Buyer = buyer;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (Product product in Products)
            {
                total += product.Price;
            }
            return total;
        }
    }
}

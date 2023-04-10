using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_shop
{
    public class Order
    {
        public static int _orderID = 0;
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }

        public Order(string customerName, string email, string address, DateTime orderDate)
        {
            _orderID++;
            CustomerName = customerName;
            Email = email;
            Address = address;
            OrderDate = orderDate;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void RemoveProduct(Product product) 
        { 
            Products.Remove(product);
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

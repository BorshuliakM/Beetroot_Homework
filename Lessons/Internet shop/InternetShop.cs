namespace Internet_shop
{
    public class InternetShop
    {
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }

        public InternetShop()
        {
            Products = new List<Product>();
            Orders = new List<Order>();
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void RemoveProduct(Product product) 
        { 
            Products.Remove(product);
        }
        public void PlaceOrder(Order order)
        {
            Orders.Add(order);
            Console.WriteLine($"Hello {order.CustomerName}" +
                $"Your order {Order._orderID} submitted");
        }
    }
}
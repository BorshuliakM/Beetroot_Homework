namespace Internet_shop
{
    public class InternetShop
    {
        public List<Product> Products { get; set; }
        public List<> Customers { get; set; }
        public List<Order> Orders { get; set; }

        public Shop()
        {
            Products = new List<Product>();
            Customers = new List<Customer>();
            Orders = new List<Order>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void PlaceOrder(Order order)
        {
            Orders.Add(order);
        }

    }
}
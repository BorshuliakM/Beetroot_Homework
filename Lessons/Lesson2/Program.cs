using Internet_shop;
internal class Program
{
    private static void Main(string[] args)
    {
        //розумію що це фігня, а не ввід, але так і не придумав як це можна зробити, можливо якось окремим методом чи класом (
        InternetShop shop = new();
        Console.WriteLine("Input product name");
        string productName = Console.ReadLine();
        Console.WriteLine("Input product price");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Input some product descriprtion");
        string desc = Console.ReadLine();
        Product p1 = new(productName, price, desc);
        shop.AddProduct(p1);

        Console.WriteLine("Input customer name");
        string customerName = Console.ReadLine();
        Console.WriteLine("Input email");
        string email = Console.ReadLine();
        Console.WriteLine("Input addres");
        string addres = Console.ReadLine();
        Order order = new(customerName, email, addres, DateTime.UtcNow);
        order.AddProduct(p1);
        shop.PlaceOrder(order);
        
    }
}





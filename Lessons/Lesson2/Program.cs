internal class Program
{
    private static void Main(string[] args)
    {
        A b = new B();

        Console.WriteLine(b.Method());
    }
}
public class A

{

    public string Method() => "Call A";

}



public class B : A

{

    public string Method() => "Call B";

}
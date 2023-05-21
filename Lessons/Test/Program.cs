namespace Test;

internal class Program
{
    private static void Main(string[] args)
    {
        TestClass test = new TestClass();
        test.Print();
        test.TestMethodAddition(7, 8);
    }
}
namespace Test;

internal class TestClass
{
    public int TestProperty { get; set; }
    public int TestProperty2 { get; set; }
    public TestClass()
    {
        TestProperty = 1;
        TestProperty2 = 2;
    }
    public int TestMethodAddition(int testArg, int testArg2) => testArg + testArg2;
    public void Print() => Console.WriteLine($"TestProperty = {TestProperty}\nTestProperty2 = {TestProperty2}");
}

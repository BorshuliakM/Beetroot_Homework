internal class Program
{
    private static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        int[] arr = new int[4];
        stack.Push(47);
        stack.Push(4);
        stack.Push(8);
        Console.WriteLine("Count = " + stack.Count());
        Console.WriteLine("Peek = " + stack.Peek());
        stack.CopyTo(arr, 0);
        foreach (var k in arr)
        {
            Console.WriteLine(k);
        }
    }
}
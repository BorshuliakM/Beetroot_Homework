internal class Program
{
    private static void Main(string[] args)
    {
        int sum;
        Console.WriteLine(Max(7, 8));
        Console.WriteLine(Max(6, 4, 8));
        Console.WriteLine(Min(4, 8));
        Console.WriteLine(Min(7, 3, 8));
        var x = TrySumIfOdd(5, 9, out sum);
        Console.WriteLine($"{x}\n{sum}");
        Console.WriteLine(Repeat("str", 4));
    }
    static int Max(int a, int b)
    {
        return Math.Max(a, b);
    }
    static int Max(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }
    static int Min(int a, int b)
    {
        return Math.Min(a, b);
    }
    static int Min(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }

    static bool TrySumIfOdd(int a, int b, out int sum)
    {
        sum = 0;
        for (int i = a; i <= b; i++)
        {
            sum += i;
        }
        if (sum % 2 != 0) return true;
        else return false;
    }
    static string Repeat(string X, int N)
    {
        string str = "";
        for (int i = 0; i < N; i++)
        {
            str += X;
        }
        return str;
    }
}
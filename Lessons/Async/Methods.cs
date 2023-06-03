namespace MethodsHomework;

public static class Methods
{
    public static int Max(int a, int b)
    {
        return Math.Max(a, b);
    }
    public static int Max(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }
    public static int Min(int a, int b)
    {
        return Math.Min(a, b);
    }
    public static int Min(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }

    public static bool TrySumIfOdd(int a, int b, out int sum)
    {
        sum = 0;
        for (int i = a; i <= b; i++)
        {
            sum += i;
        }
        if (sum % 2 != 0) return true;
        else return false;
    }
    public static string Repeat(string X, int N)
    {
        string str = "";
        for (int i = 0; i < N; i++)
        {
            str += X;
        }
        return str;
    }
}


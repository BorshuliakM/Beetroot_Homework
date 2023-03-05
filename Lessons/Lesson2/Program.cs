try
{
    int result = 0;
    Console.Write("Input x = ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Input y = ");
    int y = int.Parse(Console.ReadLine());
    if (x > y)
    {
        for (int i = y; i <= x; i++)
        {
            result += i;
        }
    }
    else if (x < y)
    {
        for (int i = x; i <= y; i++)
        {
            result += i;
        }
    }
    else result = x;
    Console.WriteLine("Result " + result);
    Console.ReadKey();
}
catch (FormatException)
{
    Console.WriteLine("Invalid Input");
}

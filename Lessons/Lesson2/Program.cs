Console.WriteLine(Max(7));
Console.WriteLine(Max(7,8,9));
Console.WriteLine(Min(7, 8));

int Max(params int[] numbers) => numbers.Max();

int Min(params int[] numbers) => numbers.Min();

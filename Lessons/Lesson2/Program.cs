int[] numbers = new int[10];

for(int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{i + 1} = ");
    numbers[i] = int.Parse(Console.ReadLine());
}
foreach(int i in numbers)
{ 
    Console.WriteLine($"[{i}]"); 
}
Console.ReadKey();

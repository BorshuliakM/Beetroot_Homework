int Alphabet, Digits, Special;
bool a, b;
a = Compare("Numbers", " numbers");
b = Compare("Numbers", " nun");
Analyze("Array", out Alphabet, out Digits, out Special);
string str = Sort("Carrot");
List<char> duplicate = Duplicate("debugg Hello World");

Console.Write($"Compare:\n{a}\n{b}\n");
Console.WriteLine($"Analyze:\n{Alphabet}\n{Digits}\n{Special}\n");
Console.WriteLine($"Sort:\n{str}\n");
Console.WriteLine("Duplicates:");
foreach (char c in duplicate)
{
    Console.Write(c);
}

static bool Compare(string str1, string str2)
{
    if (str1.Length != str2.Length) return false;

    for (int i = 0; i < str1.Length; i++)
    {
        if (str1[i] != str2[i]) return false;
    }
    return true;
}
static void Analyze(string input, out int numAlphabetic, out int numDigits, out int numSpecial)
{
    numAlphabetic = 0;
    numDigits = 0;
    numSpecial = 0;
    foreach (char c in input)
    {
        if (char.IsLetter(c))
        {
            numAlphabetic++;
        }
        else if (char.IsDigit(c))
        {
            numDigits++;
        }
        else numSpecial++;
    }
}
static string Sort(string input)
{
    char[] chars = input.ToCharArray();
    Array.Sort(chars, StringComparer.OrdinalIgnoreCase);
    input = new string(chars);
    return input;
}
static List<char> Duplicate(string input)
{
    List<char> duplicates = new List<char>();
    List<char> seen = new List<char>();
    foreach (char c in input)
    {
        if (seen.Contains(c) && !duplicates.Contains(c))
        {
            duplicates.Add(c);
        }
        else
        {
            seen.Add(c);
        }
    }
    return duplicates;
}
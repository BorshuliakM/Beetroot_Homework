using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        FileInput("Євген Ш.Л.", "+380977489712");
        Search("Євген");
    }

    private static void FileInput(string Fullname, string PhoneNumber)
    {
        string name_pattern = @"^[А-ЩЬЮЯҐЄІЇ][а-щьюяґєії']+\s[А-ЩЬЮЯҐЄІЇ]\.[А-ЩЬЮЯҐЄІЇ]\.$";
        string phone_pattern = @"\+380\d{9}";
        Regex name = new Regex(name_pattern);
        Regex phone = new Regex(phone_pattern);
        if (name.IsMatch(Fullname) && phone.IsMatch(PhoneNumber)) File.AppendAllText("C:\\Users\\borsh\\Source\\Repos\\BorshuliakM\\Beetroot_Homework\\Lessons\\Lesson2\\TelephoneBook.txt", 
            Fullname+" "+PhoneNumber);
        else Console.WriteLine("Incorrect input");
    }
    private static void Search(string input)
    {
        string[] users = File.ReadAllLines("C:\\Users\\borsh\\Source\\Repos\\BorshuliakM\\Beetroot_Homework\\Lessons\\Lesson2\\TelephoneBook.txt");
        List<string> matches = new List<string>();
        foreach (var user in users)
        {
            if (user.Contains(input))
            {
                matches.Add(user);
            }
        }

        Console.WriteLine("Found users: ");
        foreach (var user in matches)
        {
            Console.WriteLine(user);
        }
    }
}

using Newtonsoft.Json;

namespace Lesson_20;

internal class Program
{
    /*
    find out who is located farthest north/south/west/east using latitude/longitude data
    find max and min distance between 2 persons
    find 2 persons whos ‘about’ have the most same words
    find persons with same friends(compare by friend’s name)
    */

    private static void Main(string[] args)
    {
        var persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(File.ReadAllText("data.json"));
    }
}

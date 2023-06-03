using Newtonsoft.Json;

namespace Linq;

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
        //1
        var north = FarthestNorth(persons);
        var south = FarthestSouth(persons);
        var west = FarthestWest(persons);
        var east = FarthestEast(persons);
        //2
        PersonsDistance(persons, out var MaxDist, out var MinDist);
        //3
        SameAbout(persons, out var sameAbout);
        //4
        SameFriends(persons, out var sameFriends);

    }
    //find out who is located farthest north/south/west/east using latitude/longitude data
    public static Person FarthestNorth(IEnumerable<Person> persons) => persons.OrderByDescending(p => p.Latitude).First();
    public static Person FarthestSouth(IEnumerable<Person> persons) => persons.OrderBy(p => p.Latitude).First();
    public static Person FarthestWest(IEnumerable<Person> persons) => persons.OrderBy(p => p.Longitude).First();
    public static Person FarthestEast(IEnumerable<Person> persons) => persons.OrderByDescending(p => p.Longitude).First();

    //find max and min distance between 2 persons
    public static double Distance(double lat1, double lon1, double lat2, double lon2)
    {
        const double R = 6371; // radius of the earth in km
        double dLat = (lat2 - lat1) * Math.PI / 180;
        double dLon = (lon2 - lon1) * Math.PI / 180;
        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(lat1 * Math.PI / 180) * Math.Cos(lat2 * Math.PI / 180) * Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        return R * c;
    }
    public static void PersonsDistance(IEnumerable<Person> persons, out UserDistanceRecord max, out UserDistanceRecord min)
    {
        var personsArray = persons.ToArray();
        max = new UserDistanceRecord(0, 0, 0);
        min = new UserDistanceRecord(0, 0, 50000);
        for (int i = 0; i < personsArray.Length - 1; i++)
            for (int j = i + 1; j < personsArray.Length; j++)
            {
                var rec = new UserDistanceRecord(
                        personsArray[i].Index, personsArray[j].Index,
                        Distance(personsArray[i].Latitude, personsArray[i].Longitude,
                        personsArray[j].Latitude, personsArray[j].Longitude));
                if (rec.Distance < min.Distance) min = rec;
                else if (rec.Distance > max.Distance) max = rec;
            }
    }
    //find 2 persons whos ‘about’ have the most same words
    /* 
     * public static List<Person> SameAbout(IEnumerable<Person> persons)
    {
        List<Person> personsList = persons.ToList();
        var groups = personsList.GroupBy(x => x.About).
            Where(g => g.Count() > 1).
            Select(y => y.Key)
            .ToList();
        return persons;
    }*/

    public static void SameAbout(IEnumerable<Person> persons,
        out UserAboutRecord about)
    {
        about = new UserAboutRecord(null, null, 0);
        var personsList = persons.ToArray();
        for (int i = 0; i < personsList.Length - 1; i++)
            for (int j = i + 1; j < personsList.Length; j++)
            {
                var first = personsList[i];
                var second = personsList[j];
                var firstWords = SplitAbout2(first);
                var secondWords = SplitAbout2(second);
                var common = firstWords.Intersect(secondWords).Count();
                if (common > about.WordsCount)
                    about = new UserAboutRecord(first, second, common);

                var arr = new char[] { ',', '.' };
                var sp = first.About.Split(arr);
            }
    }
    private static string[] SplitAbout2(Person person)
    {
        return person.About.ToLower().Split('.', ',', ' ');
    }
    //find persons with same friends(compare by friend’s name)
    public static void SameFriends(IEnumerable<Person> persons, out UserFriendsRecord user)
    {
        user = null;
        var sameFriends = persons
            .Select(p => new UserFriendsRecord(p.Index,
                string.Join("", p.Friends
                    .OrderBy(f => f.Name)
                    .Select(f => f.Name))))
            .GroupBy(p => p.FriendStr)
            .Where(gr => gr.Count() > 1)
            .ToList();
        if (sameFriends.Count > 0)
        {
            user = sameFriends.SelectMany(gr => gr).First();
        }
    }
    public record UserFriendsRecord(int Index, string FriendStr);
    public record UserAboutRecord(Person first, Person second, int WordsCount);
    public record UserDistanceRecord(int FirstIndex, int SecondIndex, double Distance);
}

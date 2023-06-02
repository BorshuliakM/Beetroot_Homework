using Lesson24;
using System.Net.Http.Json;
using System.Text.Json;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        string category = CategorySelection();
        NewsModel? mod = await GetData(category);
        ShowNews(mod);
    }
    private static async Task<NewsModel?> GetData(string categoryName)
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"https://inshorts.deta.dev/news?category={categoryName}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                NewsModel newsByCategory = JsonSerializer.Deserialize<NewsModel>(responseBody);
                return newsByCategory;
            }
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
    }
    private static string CategorySelection()
    {
        Console.WriteLine(
            "News category list:" +
            "\n1 - All" +
            "\n2 - Business" +
            "\n3 - Sports" +
            "\n4 - World" +
            "\n5 - Politics" +
            "\n6 - Technology" +
            "\n7 - Startup" +
            "\n8 - Entertainment" +
            "\n9 - Miscellaneous" +
            "\n10 - Hatke" +
            "\n11 - Science" +
            "\n12 - Automobile");
        Console.WriteLine("Pick a category number: ");
        bool isParsed = int.TryParse(Console.ReadLine(), out int categoryNumber);
        if (isParsed && categoryNumber > 0 && categoryNumber <= 12)
        {
            string category = categoryNumber switch
            {
                1 => "all",
                2 => "business",
                3 => "sports",
                4 => "world",
                5 => "politics",
                6 => "technology",
                7 => "startup",
                8 => "entertainment",
                9 => "miscellaneous",
                10 => "hatke",
                11 => "science",
                12 => "automobile",
                _ => "all"
            };
            return category;
        }
        else
        {
            throw new Exception("Incorrect Input!\nPick a number from 1 to 12");
        }
    }
    private static void ShowNews(NewsModel news)
    {
        if (news == null)
        {
            Console.WriteLine("No news available.");
            return;
        }

        List<NewsData> newsData = news.Data;
        if (newsData == null || newsData.Count == 0)
        {
            Console.WriteLine("No news data available.");
            return;
        }
        foreach (var item in newsData)
        {
            Console.WriteLine($"Author: {item.Author}\nContent: {item.Content}");
        }
    }
}
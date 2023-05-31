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

        ShowNewsCategory();
        string category_name = CategorySelection();
        try
        {
            NewsModel newsByCategory = await new HttpClient()
                .GetFromJsonAsync<NewsModel>($"https://inshorts.deta.dev/news?category={category_name}");
            ShowNews(newsByCategory);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    private static void ShowNewsCategory()
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
    }
    private static string CategorySelection()
    {
        int category_number;
        string category;
        Console.WriteLine("Pick a category number: ");
        bool res = int.TryParse(Console.ReadLine(), out category_number);
        if (res == true && category_number > 0 && category_number <= 12)
        {
            category = category_number switch
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
                _ => "All"
            };
            return category;
        }
        else
        {
            throw new Exception("IncorrectInput!\nPick a number from 1 to 12");
        }
    }
    private static void ShowNews(NewsModel news)
    {
        List<NewsData> newsData = news.Data;
        foreach (var item in newsData) 
        {
            Console.WriteLine($"Author: {item.Author}\nContent: {item.Content}");
        }
    }
}
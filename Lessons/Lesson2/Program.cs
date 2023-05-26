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
        HttpClient client = new HttpClient();
        var response = await client.GetAsync("https://inshorts.deta.dev/news?category=science");
        string content = await response.Content.ReadAsStringAsync();
        NewsModel news = await response.Content.ReadFromJsonAsync<NewsModel>();
    }
}
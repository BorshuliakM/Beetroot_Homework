using Xunit;
using Async;
using System.Text.Json;

namespace TestAsync;
public class Tests
{
    [Theory]
    [InlineData("all")]
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
}
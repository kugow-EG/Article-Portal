using ArticlePortal.Model;
using System.Net.Http.Json;

public class FetchDataServices
{
    private readonly HttpClient _httpClient;

    public FetchDataServices(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Article>> GetArticlesAsync()
    {
        var response = await _httpClient.GetAsync("https://ps-dev-1-partnergateway.patientsky.dev/assignment/articles");
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error fetching articles. Status Code: {response.StatusCode}");
        }
        return await response.Content.ReadFromJsonAsync<List<Article>>() ?? new List<Article>();
    }

    public async Task<Article> GetArticleByIdAsync(int id)
    {
        var response = await _httpClient.GetAsync($"https://ps-dev-1-partnergateway.patientsky.dev/assignment/articles/{id}");
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error fetching article. Status Code: {response.StatusCode}");
        }
        return await response.Content.ReadFromJsonAsync<Article>() ?? throw new Exception("Article data is null.");
    }
}

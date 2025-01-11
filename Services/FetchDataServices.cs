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
        try
        {
            return await _httpClient.GetFromJsonAsync<List<Article>>("https://ps-dev-1-partnergateway.patientsky.dev/assignment/articles");
        }
        catch (Exception)
        {
            throw new Exception("Failed to fetch articles.");
        }
    }

    public async Task<Article> GetArticleByIdAsync(int id)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<Article>($"https://ps-dev-1-partnergateway.patientsky.dev/assignment/articles/{id}");
        }
        catch (Exception)
        {
            throw new Exception("Failed to fetch the article details.");
        }
    }
}

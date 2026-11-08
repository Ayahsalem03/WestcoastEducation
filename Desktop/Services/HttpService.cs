
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Desktop.Services;

public class HttpService<T> where T : class
{
    private readonly string _baseUrl =
        "https://westcoasteducation-1e09.restdb.io/rest/";

    private readonly string _apiKey =
        Environment.GetEnvironmentVariable("RESTDB_API_KEY")
        ?? throw new InvalidOperationException(
            "RESTDB_API_KEY saknas.");

    public async Task<List<T>> Get(string resource)
    {
        using HttpClient client = new();

        client.DefaultRequestHeaders.Add("x-apikey", _apiKey);

        var response = await client.GetAsync(_baseUrl + resource);

        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadAsStringAsync();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        return JsonSerializer.Deserialize<List<T>>(result, options)
               ?? new List<T>();
    }
}

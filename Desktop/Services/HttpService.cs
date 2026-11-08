
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
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

    private readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = null,
        PropertyNameCaseInsensitive = true
    };

    public async Task<List<T>> Get(string resource)
    {
        using HttpClient client = new();

        client.DefaultRequestHeaders.Add("x-apikey", _apiKey);

        var response = await client.GetAsync(
            _baseUrl + resource);

        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<List<T>>(
            result, _options) ?? new List<T>();
    }

    public async Task<T?> Post(string resource, T item)
    {
        using HttpClient client = new();

        client.DefaultRequestHeaders.Add("x-apikey", _apiKey);

        var json = JsonSerializer.Serialize(item, _options);

        System.Diagnostics.Debug.WriteLine(
            $"JSON som skickas: {json}");

        var response = await client.PostAsJsonAsync(
            _baseUrl + resource, item, _options);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<T>(
            _options);
    }
}

// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using WebAPIClient;

internal class Program
{
    private static readonly HttpClient client = new HttpClient();

    private static async Task ProcessPosts()
    {
        /* var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
        var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(await streamTask);

        foreach (var repo in repositories)
        Console.WriteLine(repo.userId); */
        var stringTask = client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
        var msg = await stringTask;
        Console.WriteLine(msg);
    }
    static async Task Main(string[] args)
    {
        await ProcessPosts();
    }
}
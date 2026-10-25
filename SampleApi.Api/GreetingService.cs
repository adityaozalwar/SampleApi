namespace SampleApi.Api;

public class GreetingService
{
    public string Greet(string name) =>
        string.IsNullOrWhiteSpace(name) ? "Hello, stranger!" : $"Hello, {name}!";
}
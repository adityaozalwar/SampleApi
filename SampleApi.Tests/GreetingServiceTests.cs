using SampleApi.Api;

namespace SampleApi.Tests;

public class GreetingServiceTests
{
    [Fact]
    public void Greet_WithName_ReturnsGreeting() =>
        Assert.Equal("Hello, Sam!", new GreetingService().Greet("Sam"));

    [Fact]
    public void Greet_Empty_ReturnsStranger() =>
        Assert.Equal("Hello, stranger!", new GreetingService().Greet(""));
}
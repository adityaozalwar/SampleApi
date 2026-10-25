using SampleApi.Api;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<GreetingService>();
var app = builder.Build();

app.MapGet("/", () => "API is running");
app.MapGet("/greet/{name}", (string name, GreetingService svc) => svc.Greet(name));

app.Run();
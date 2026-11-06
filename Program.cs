var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://0.0.0.0:8080");
var app = builder.Build();

app.MapGet("/health", () => Results.Text("OK\n"));
app.MapGet("/demo", () => Results.Redirect("/"));
app.MapGet("/", IResult () =>
    throw new InvalidOperationException("Intentional root-page failure for deployment testing."));
app.MapGet("/greeting", () =>
{
    // This is a deliberately public greeting, not a diagnostics/environment dump.
    var greeting = Environment.GetEnvironmentVariable("SAMPLE_GREETING");
    return Results.Text($"App Service Builder / dotnet-web: {(string.IsNullOrEmpty(greeting) ? "Hello" : greeting)}\n");
});

app.Run();

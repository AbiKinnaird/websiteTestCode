var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Welcome to My Simple Website!");
app.MapGet("/about", () => "This is a simple C# website example.");

app.Run();

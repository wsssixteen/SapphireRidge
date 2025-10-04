using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Welcome to Sapphire Ridge!");
app.MapGet("/about", () => "Sapphire Ridge was founded in 2023 to provide exceptional services.");

app.Run();

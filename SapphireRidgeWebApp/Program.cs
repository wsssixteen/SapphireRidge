using Microsoft.AspNetCore.Rewrite;
using SapphireRidgeWebApp.Interfaces;
using SapphireRidgeWebApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IWelcomeService, WelcomeService>();

var app = builder.Build();

// Custom Middleware
app.Use(async (context, next) =>
{
    await next();
    Console.WriteLine($"{context.Request.Method} {context.Request.Path} {context.Response.StatusCode}");
});

app.UseRewriter(new RewriteOptions().AddRedirect("history", "about"));

app.MapGet("/", (IWelcomeService welcomeService) => welcomeService.GetWelcomeMessage());
app.MapGet("/about", () => "Sapphire Ridge was founded in 2023 to provide exceptional services.");

app.Run();

using CryptoCactus.WebAPI.Hubs;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Mvc; // Добавьте это пространство имен
using System.Text.Json;
using CryptoCactus.Domain.CryproFactoryMethod; // Для работы с JSON

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapHub<ChatHub>("/chat");

// Обработчик GET-запроса для главной страницы
app.MapGet("/", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("wwwroot/index.html");
});

// Обработчик POST-запроса для получения выбранной криптовалюты
app.MapPost("/api/crypto", async (HttpContext context) =>
{
    var requestBody = await new StreamReader(context.Request.Body).ReadToEndAsync();
    var json = JsonDocument.Parse(requestBody);
    var selectedCrypto = json.RootElement.GetProperty("crypto").GetString();

    // Перенаправляем на GET-обработчик с выбранной валютой
    context.Response.Redirect($"/{selectedCrypto}.html");
});

// Обработчик GET-запроса для валюты
app.MapGet("/{currency}.html", async (HttpContext context, string currency) =>
{
    // Устанавливаем тип контента
    context.Response.ContentType = "text/html; charset=utf-8";
    var html = FactoryMethods.FactoryMthodHtmlCryptoCurrency(currency);
    // Отправляем сгенерированный HTML-код в ответе
    await context.Response.WriteAsync(html);
});



app.Run();

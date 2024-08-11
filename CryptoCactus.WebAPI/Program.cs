using CryptoCactus.WebAPI.Hubs;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Mvc; // �������� ��� ������������ ����
using System.Text.Json;
using CryptoCactus.Domain.CryproFactoryMethod; // ��� ������ � JSON

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapHub<ChatHub>("/chat");

// ���������� GET-������� ��� ������� ��������
app.MapGet("/", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("wwwroot/index.html");
});

// ���������� POST-������� ��� ��������� ��������� ������������
app.MapPost("/api/crypto", async (HttpContext context) =>
{
    var requestBody = await new StreamReader(context.Request.Body).ReadToEndAsync();
    var json = JsonDocument.Parse(requestBody);
    var selectedCrypto = json.RootElement.GetProperty("crypto").GetString();

    // �������������� �� GET-���������� � ��������� �������
    context.Response.Redirect($"/{selectedCrypto}.html");
});

// ���������� GET-������� ��� ������
app.MapGet("/{currency}.html", async (HttpContext context, string currency) =>
{
    // ������������� ��� ��������
    context.Response.ContentType = "text/html; charset=utf-8";
    var html = FactoryMethods.FactoryMthodHtmlCryptoCurrency(currency);
    // ���������� ��������������� HTML-��� � ������
    await context.Response.WriteAsync(html);
});



app.Run();

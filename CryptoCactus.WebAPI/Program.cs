using CryptoCactus.WebAPI.Hubs;
using Microsoft.AspNetCore.SignalR;  // ������������ ���� ������ ChatHub

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();      // ���������� ������� SignalR

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapHub<ChatHub>("/chat");   // ChatHub ����� ������������ ������� �� ���� /chat

app.MapGet("/", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("wwwroot/index.html");
});

app.Run();

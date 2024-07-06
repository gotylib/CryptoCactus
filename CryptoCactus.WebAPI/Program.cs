using CryptoCactus.WebAPI.Hubs;
using Microsoft.AspNetCore.SignalR;   // ������������ ���� ������ ChatHub

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();      // ���������� ������� SignalR

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapHub<CryptoHub>("/chat");   // ChatHub ����� ������������ ������� �� ���� /chat

app.Run();
using CryptoCactus.WebAPI.Hubs;
using Microsoft.AspNetCore.SignalR;   // ������������ ���� ������ ChatHub
using CryptoCactus.Domain;
using CryptoCactus.WebAPI.Hubs;
using Microsoft.AspNetCore.SignalR;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();      // ���������� ������� SignalR

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();


app.MapHub<ChatHub>("/chat");   // ChatHub ����� ������������ ������� �� ���� /chat


app.Run();
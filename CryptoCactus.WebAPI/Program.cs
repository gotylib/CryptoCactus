using CryptoCactus.WebAPI.Hubs;
using Microsoft.AspNetCore.SignalR;   // пространство имен класса ChatHub
using CryptoCactus.Domain;
using CryptoCactus.WebAPI.Hubs;
using Microsoft.AspNetCore.SignalR;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();      // подключема сервисы SignalR

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();


app.MapHub<ChatHub>("/chat");   // ChatHub будет обрабатывать запросы по пути /chat


app.Run();
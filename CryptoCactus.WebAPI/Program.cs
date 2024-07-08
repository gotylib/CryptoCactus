<<<<<<< HEAD
using CryptoCactus.WebAPI.Hubs;
using Microsoft.AspNetCore.SignalR;   // пространство имен класса ChatHub
=======
using CryptoCactus.Domain;
using CryptoCactus.WebAPI.Hubs;
using Microsoft.AspNetCore.SignalR;
>>>>>>> db9fca3 (version: 1.7)

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();      // подключема сервисы SignalR

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

<<<<<<< HEAD
app.MapHub<CryptoHub>("/chat");   // ChatHub будет обрабатывать запросы по пути /chat
=======
app.MapHub<ChatHub>("/chat");   // ChatHub будет обрабатывать запросы по пути /chat
>>>>>>> db9fca3 (version: 1.7)

app.Run();
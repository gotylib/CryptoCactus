<<<<<<< HEAD
using CryptoCactus.WebAPI.Hubs;
using Microsoft.AspNetCore.SignalR;   // ������������ ���� ������ ChatHub
=======
using CryptoCactus.Domain;
using CryptoCactus.WebAPI.Hubs;
using Microsoft.AspNetCore.SignalR;
>>>>>>> db9fca3 (version: 1.7)

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();      // ���������� ������� SignalR

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

<<<<<<< HEAD
app.MapHub<CryptoHub>("/chat");   // ChatHub ����� ������������ ������� �� ���� /chat
=======
app.MapHub<ChatHub>("/chat");   // ChatHub ����� ������������ ������� �� ���� /chat
>>>>>>> db9fca3 (version: 1.7)

app.Run();
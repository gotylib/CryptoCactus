using CryptoCactus.Domail.Markets.ConcreteExchanges;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.SignalR;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;


var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        BybitExchange bb = new BybitExchange();
        app.Run(async (context) =>
        {
            await bb.GetOnlyOneCurrencByAPI("BTCUSDT");
            var BTC = bb.Currencies["BTCUSDT"];
            var respinse = context.Response;
            await respinse.WriteAsync($"Bybit:{BTC}");
           /* respinse.Headers.ContentType = "text/html; charset=utf-8";
            await respinse.SendFileAsync("html/index.html");*/
        });
        app.Run();

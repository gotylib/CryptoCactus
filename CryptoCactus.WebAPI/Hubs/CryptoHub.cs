using CryptoCactus.Domail.Markets.ConcreteExchanges;
<<<<<<< HEAD
using Microsoft.AspNetCore.SignalR;
using System;
=======
using Microsoft.AspNet.SignalR.Messaging;
using Microsoft.AspNetCore.SignalR;
>>>>>>> db9fca3 (version: 1.7)

namespace CryptoCactus.WebAPI.Hubs
{
    public class ChatHub : Hub
    {
<<<<<<< HEAD
        public async Task Send(BybitExchange items)
        {
            await items.GetOnlyOneCurrencByAPI("BTCUSND");
            var BTC = items.Currencies["BTCUSDT"];
            await Clients.Caller.SendAsync("Receive", BTC);
        }
        
=======
        BybitExchange bybitExchange = new BybitExchange();
        public async Task Send()
        { 
            await bybitExchange.GetOnlyOneCurrencByAPI("BTCUSDT");
            await this.Clients.All.SendAsync("Receive", bybitExchange.Currencies["BTCUSDT"].ToString());
        } 
>>>>>>> db9fca3 (version: 1.7)
    }


}




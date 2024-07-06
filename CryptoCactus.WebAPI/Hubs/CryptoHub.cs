using CryptoCactus.Domail.Markets.ConcreteExchanges;
using Microsoft.AspNetCore.SignalR;
using System;

namespace CryptoCactus.WebAPI.Hubs
{
    public class CryptoHub : Hub
    {
        public async Task Send(BybitExchange items)
        {
            await items.GetOnlyOneCurrencByAPI("BTCUSND");
            var BTC = items.Currencies["BTCUSDT"];
            await Clients.Caller.SendAsync("Receive", BTC);
        }
        
    }


}




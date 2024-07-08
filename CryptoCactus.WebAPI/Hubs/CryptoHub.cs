using CryptoCactus.Domail.Markets.ConcreteExchanges;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNet.SignalR.Messaging;
using Microsoft.AspNetCore.SignalR;


namespace CryptoCactus.WebAPI.Hubs
{
    public class ChatHub : Hub
    {
        BybitExchange bybitExchange = new BybitExchange();
        public async Task Send(string message)
        { 

            await bybitExchange.GetOnlyOneCurrencByAPI("BTCUSDT");
            await this.Clients.All.SendAsync("Receive", bybitExchange.Currencies["BTCUSDT"].ToString());
        } 
    }


}




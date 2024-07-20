using Microsoft.AspNetCore.SignalR;
using CryptoCactus.Domain;
using CryptoCactus.Domain.CryptoAbstractFactory;

namespace CryptoCactus.WebAPI.Hubs
{
    public class ChatHub : Hub
    {
        CryptoAbstractFactory cryptoAbstractFactory = new CryptoAbstractFactory();
        List<string> valueOfCurrence = new List<string>();
        public async Task Send(string message)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, message); // Добавляем соединение в группу валюты
            await cryptoAbstractFactory.UpdateOnlyOneCurrencForAllCryptoExchangesAsync(message);
            valueOfCurrence = await cryptoAbstractFactory.OnlyOneCurrencForAllCryptoExchangesToListAsync(message);
            await Clients.Group(message).SendAsync("Receive", valueOfCurrence); // Отправляем только в группу
        }

    }
}

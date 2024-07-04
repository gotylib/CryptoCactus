using Microsoft.AspNetCore.SignalR;

namespace CryptoCactus.WebAPI.Hubs
{
    public class CryptoHub : Hub
    {
        public async Task JoinCrypto()
        {
            string group = "user";
            await Groups.AddToGroupAsync(Context.ConnectionId, group);
        }
    }
}

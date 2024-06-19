using CryptoCactus.Domain.Markets.Abstract;
using bybit.net.api;
using bybit.net.api.ApiServiceImp;
using bybit.net.api.Models.Market;
using bybit.net.api.Models;
using System.Text.Json;
using CryptoCactus.Domail.Markets.BybitExchanges;

namespace CryptoCactus.Domail.Markets.ConcreteExchanges
{
    public class BybitExchange : CryptoExchange
    {
        public override async void GetCurrenciesByAPI(string? apiKey = null, string? apiSecret = null)
        {
            
        }

        public override async void GetOnlyOneCurrencByAPI(string nameOfCurrenc, string? apiKey = null, string? apiSecret = null)
        {
            BybitMarketDataService market = new(url: BybitConstants.HTTP_MAINNET_URL, debugMode: true);
            var klineInfo = await market.GetMarketKline(Category.SPOT, nameOfCurrenc, MarketInterval.OneMinute, limit: 1);
            var result = JsonSerializer.Deserialize<ResponseSerialaze>(klineInfo);
            Console.WriteLine(result.result.list[0][4]);
        }
    }
}

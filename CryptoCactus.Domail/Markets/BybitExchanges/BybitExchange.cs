using CryptoCactus.Domain.Markets.Abstract;
using bybit.net.api;
using bybit.net.api.ApiServiceImp;
using bybit.net.api.Models.Market;
using bybit.net.api.Models;
using System.Text.Json;
using CryptoCactus.Domail.Markets.BybitExchanges;
using System.Globalization;

namespace CryptoCactus.Domail.Markets.ConcreteExchanges
{
    public class BybitExchange : CryptoExchange
    {
 

        public override async Task GetCurrenciesByAPIAsync(string? apiKey = null, string? apiSecret = null)
        {
            
        }

        public override async Task GetOnlyOneCurrencByAPIAsync(string nameOfCurrenc, string? apiKey = null, string? apiSecret = null)
        {
            BybitMarketDataService market = new(url: BybitConstants.HTTP_MAINNET_URL, debugMode: true);
            var klineInfo = await market.GetMarketKline(Category.SPOT, string.Concat(nameOfCurrenc, "USDT"), MarketInterval.OneMinute, limit: 1);
            var result = JsonSerializer.Deserialize<BybitResponseSerialaze>(klineInfo);
            CurrenciesAppender(nameOfCurrenc, double.Parse(result.result.list[0][4], CultureInfo.InvariantCulture));
        }
    }
}

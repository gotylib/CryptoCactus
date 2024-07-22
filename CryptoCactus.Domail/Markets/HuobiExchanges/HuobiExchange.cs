using CryptoCactus.Domain.Markets.Abstract;
using System.Text.Json;


namespace CryptoCactus.Domain.Markets.HuobiExchanges
{
    public class HuobiExchange : CryptoExchange
    {
        public override async Task GetCurrenciesByAPIAsync(string? apiKey = null, string? apiSecret = null)
        {
            throw new NotImplementedException();
        }

        public override async Task GetOnlyOneCurrencByAPIAsync(string nameOfCurrenc, string? apiKey = null, string? apiSecret = null)
        {
            string url = string.Concat("https://api.huobi.pro/market/trade?symbol=", string.Concat(nameOfCurrenc.ToLower(), "usdt"));
            var kLineInfo = await httpConnector.HttpConnect(url);
            var result = JsonSerializer.Deserialize<HuobiResponseSerialaze>(kLineInfo);
            CurrenciesAppender(nameOfCurrenc, result.tick.data[0].price);
        }
    }
}

using CryptoCactus.Domain.Markets.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CryptoCactus.Domain.Markets.KucoinExchanges
{
    public class KucoinExchange : CryptoExchange
    {
        public override async Task GetCurrenciesByAPIAsync(string? apiKey = null, string? apiSecret = null)
        {
            throw new NotImplementedException();
        }

        public override async Task GetOnlyOneCurrencByAPIAsync(string nameOfCurrenc, string? apiKey = null, string? apiSecret = null)
        {
            string url = string.Concat("https://api.kucoin.com/api/v1/market/stats?symbol=", string.Concat(nameOfCurrenc, "-USDT"));
            var kLineInfo = await httpConnector.HttpConnect(url);
            var result = JsonSerializer.Deserialize<KucoinResponseSerialaze>(kLineInfo);
            CurrenciesAppender(nameOfCurrenc, double.Parse(result.data.last, CultureInfo.InvariantCulture));
        }
    }
}

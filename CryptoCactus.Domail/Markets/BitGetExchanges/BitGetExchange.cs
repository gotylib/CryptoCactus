using CryptoCactus.Domain.Markets.Abstract;
using CryptoCactus.Domain.Markets.BingX;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CryptoCactus.Domain.Markets.BitGetExchanges
{
    public class BitGetExchange : CryptoExchange
    {
        public override async Task GetCurrenciesByAPIAsync(string? apiKey = null, string? apiSecret = null)
        {
            throw new NotImplementedException();
        }

        public override async Task GetOnlyOneCurrencByAPIAsync(string nameOfCurrenc, string? apiKey = null, string? apiSecret = null)
        {
            string url = string.Concat("https://api.bitget.com/api/v2/spot/market/tickers?symbol=", string.Concat(nameOfCurrenc, "USDT"));
            var kLineInfo = await httpConnector.HttpConnect(url);
            var result = JsonSerializer.Deserialize<BitGetResponseSerialaze>(kLineInfo);
            CurrenciesAppender(nameOfCurrenc, double.Parse(result.data[0].lastPr, CultureInfo.InvariantCulture));
        }
    }
}

using CryptoCactus.Domain.Markets.Abstract;
using CryptoCactus.Domain.Markets.OkxExchanges;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CryptoCactus.Domail.Markets.OkxExchange
{
    public class OkxExchange : CryptoExchange
    {
        public override async Task GetCurrenciesByAPIAsync(string? apiKey = null, string? apiSecret = null)
        {
            throw new NotImplementedException();
        }

        public override async Task GetOnlyOneCurrencByAPIAsync(string nameOfCurrenc, string? apiKey = null, string? apiSecret = null)
        {
            string url = string.Concat("https://www.okx.com/api/v5/market/mark-price-candles?instId=", string.Concat(nameOfCurrenc, "-USD-SWAP&limit=1"));
            var klineinfo =  await httpConnector.HttpConnect(url);
            var result = JsonSerializer.Deserialize<OkxResponseSerialaze>(klineinfo);
            CurrenciesAppender(nameOfCurrenc, double.Parse(result.Data[0][4], CultureInfo.InvariantCulture));
        }
    }
}
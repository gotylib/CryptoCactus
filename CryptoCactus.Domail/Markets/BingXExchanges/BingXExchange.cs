using CryptoCactus.Domain.Markets.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CryptoCactus.Domain.Markets.BingX
{
    public class BingXExchange : CryptoExchange
    {
        public override async Task GetCurrenciesByAPIAsync(string? apiKey = null, string? apiSecret = null)
        {
            throw new NotImplementedException();
        }

        public override async Task GetOnlyOneCurrencByAPIAsync(string nameOfCurrenc, string? apiKey = null, string? apiSecret = null)
        {
            string url = string.Concat("https://open-api.bingx.com/openApi/swap/v1/ticker/price?symbol=", string.Concat(nameOfCurrenc, "-USDT"));
            var kLineInfo = await httpConnector.HttpConnect(url);
            var result = JsonSerializer.Deserialize<BingXResponseSerialaze>(kLineInfo);
            CurrenciesAppender(nameOfCurrenc, double.Parse(result.data.price, CultureInfo.InvariantCulture));

        }
    }
}

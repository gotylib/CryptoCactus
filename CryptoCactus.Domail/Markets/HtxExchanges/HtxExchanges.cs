using CryptoCactus.Domain.Markets.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace CryptoCactus.Domain.Markets.HtxExchanges
{
    public class HtxExchanges : CryptoExchange
    {
        public override async Task GetCurrenciesByAPIAsync(string? apiKey = null, string? apiSecret = null)
        {
            throw new NotImplementedException();
        }

        public override async Task GetOnlyOneCurrencByAPIAsync(string nameOfCurrenc, string? apiKey = null, string? apiSecret = null)
        {
            string url =  string.Concat("https://api.huobi.pro/market/history/kline?period=1min&size=1&symbol=",string.Concat( nameOfCurrenc.ToLower(),"usdt"));
            var kLineInfo = await httpConnector.HttpConnect(url);
            var result = JsonSerializer.Deserialize<HtxResponseSerialaze>(kLineInfo);
            CurrenciesAppender(nameOfCurrenc, result.Data[0].Close);
        }
    }
}

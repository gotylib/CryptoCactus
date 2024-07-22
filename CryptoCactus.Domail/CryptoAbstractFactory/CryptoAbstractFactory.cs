using CryptoCactus.Domail.Markets.ConcreteExchanges;
using CryptoCactus.Domail.Markets.OkxExchange;
using CryptoCactus.Domain.Markets.Abstract;
using CryptoCactus.Domain.Markets.BingX;
using CryptoCactus.Domain.Markets.BitGetExchanges;
using CryptoCactus.Domain.Markets.HtxExchanges;
using CryptoCactus.Domain.Markets.HuobiExchanges;
using CryptoCactus.Domain.Markets.KucoinExchanges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCactus.Domain.CryptoAbstractFactory
{
    public class CryptoAbstractFactory
    {
        public List<CryptoExchange> cryptoExchanges = new List<CryptoExchange>();
        public CryptoAbstractFactory()
        {
            cryptoExchanges.Add(new BybitExchange());
            cryptoExchanges.Add(new OkxExchange());
            cryptoExchanges.Add(new HtxExchanges());
            cryptoExchanges.Add(new BingXExchange());
            cryptoExchanges.Add(new BitGetExchange());
            cryptoExchanges.Add(new KucoinExchange());
            cryptoExchanges.Add(new HuobiExchange());

        }

        public async Task<List<string>> OnlyOneCurrencForAllCryptoExchangesToListAsync(string nameOfCurrenc)
        {
            await UpdateOnlyOneCurrencForAllCryptoExchangesAsync(nameOfCurrenc);
            List<string> result = new List<string>();
            foreach(var elem in cryptoExchanges)
            {
                result.Add(elem.Currencies[nameOfCurrenc].ToString());
            }
            return result;

        }
        public async Task UpdateOnlyOneCurrencForAllCryptoExchangesAsync(string nameOfCurrenc)
        {
            foreach (var elem in cryptoExchanges)
            {
                await elem.GetOnlyOneCurrencByAPIAsync(nameOfCurrenc);
            }
        }
    }
}

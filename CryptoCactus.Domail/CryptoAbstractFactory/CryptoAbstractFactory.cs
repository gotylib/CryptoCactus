using CryptoCactus.Domail.Markets.ConcreteExchanges;
using CryptoCactus.Domail.Markets.OkxExchange;
using CryptoCactus.Domain.Markets.Abstract;
using CryptoCactus.Domain.Markets.HtxExchanges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCactus.Domain.CryptoAbstractFactory
{
    public class CryptoAbstractFactory
    {
        List<CryptoExchange> cryptoExchanges = new List<CryptoExchange>();
        CryptoExchange[] cryptExchanges = new CryptoExchange[3];
        dynamic cExchange;
        public CryptoAbstractFactory()
        {
            cryptoExchanges.Add(new BybitExchange());
            cryptoExchanges.Add(new OkxExchange());
            cryptoExchanges.Add(new HtxExchanges());
            cryptExchanges[0] = new BybitExchange();
            cryptExchanges[1] = new OkxExchange();
            cryptExchanges[2] = new HtxExchanges();
        }
        public async void FabricMethod(dynamic CryptoExchange, string update)
        {

        }
        public async Task UpdateOnlyOneCurrencInAllCryptoExchanges(string nameOfCurrenc)
        {
            foreach (var ce in cryptExchanges)
            {
                await ce.GetOnlyOneCurrencByAPI(nameOfCurrenc);
            }
            foreach (var cE in cryptoExchanges)
            {
                cExchange = cE;
                await cExchange.GetOnlyOneCurrencByAPI(nameOfCurrenc);
            }
        }
}

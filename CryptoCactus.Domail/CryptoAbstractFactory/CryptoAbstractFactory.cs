using CryptoCactus.Domail.Markets.ConcreteExchanges;
using CryptoCactus.Domail.Markets.OkxExchange;
using CryptoCactus.Domain.Markets.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCactus.Domail.CryptoAbstractFactory
{
    public class CryptoAbstractFactory
    {
        List<CryptoExchange> cryptoExchanges = new List<CryptoExchange>();
        public CryptoAbstractFactory()
        {
            cryptoExchanges.Add(new BybitExchange());
            cryptoExchanges.Add(new OkxExchange());
        }

        public void Get()
        {
            foreach(var cE in cryptoExchanges)
            {
                double a = cE.Currencies["BTCUSDT"];
            }
        }
    }
}

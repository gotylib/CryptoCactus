using bybit.net.api.Models.Market;
using bybit.net.api.Models;
using CryptoCactus.Domail.Markets.BybitExchanges;
using System.Globalization;

namespace CryptoCactus.Domain.Markets.Abstract
{
    abstract public class CryptoExchange
    {
        public Dictionary<string, double> Currencies = new Dictionary<string, double>();
        public HttpConnector httpConnector { get; set; } = new HttpConnector();
        public void CurrenciesAppender(string key,double value)
        {
            if (Currencies.ContainsKey(key))
            {
                // Update the existing value
                Currencies[key] = value; 
            }
            else
            {
                // Add a new key-value pair
                Currencies.Add(key, value);
            }
        }
        abstract public Task GetCurrenciesByAPIAsync(string? apiKey = null, string? apiSecret = null); 
        abstract public Task GetOnlyOneCurrencByAPIAsync(string nameOfCurrenc , string? apiKey = null, string? apiSecret = null);

    }
}


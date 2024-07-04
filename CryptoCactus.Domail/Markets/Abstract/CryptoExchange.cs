namespace CryptoCactus.Domain.Markets.Abstract
{
    abstract public class CryptoExchange
    {
        public Dictionary<string, double> Currencies = new Dictionary<string, double>();
        abstract public Task GetCurrenciesByAPI(string? apiKey = null, string? apiSecret = null);
        abstract public Task GetOnlyOneCurrencByAPI(string nameOfCurrenc , string? apiKey = null, string? apiSecret = null);

    }
}


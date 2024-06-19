namespace CryptoCactus.Domain.Markets.Abstract
{
    abstract public class CryptoExchange
    {
        public Dictionary<string, double> Currencies = new Dictionary<string, double>();

        abstract public void GetCurrenciesByAPI(string? apiKey = null, string? apiSecret = null);
        abstract public void GetOnlyOneCurrencByAPI(string nameOfCurrenc , string? apiKey = null, string? apiSecret = null);

    }
}

namespace CryptoCactus.Domain.Markets.Abstract
{
    abstract public class CryptoExchange
    {
        public Dictionary<string, double> Currencies = new Dictionary<string, double>();
        abstract public void GetCurrenciesByAPI(string apiKey, string apiSecret, Dictionary<string, double> Currencies);
        abstract public void GetOnlyOneCurrencByAPI(string apiKey, string apiSecret, string nameOfCurrenc, Dictionary<string, double> Currencies);

    }
}

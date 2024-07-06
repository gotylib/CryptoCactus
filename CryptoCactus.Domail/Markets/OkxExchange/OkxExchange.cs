using CryptoCactus.Domain.Markets.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCactus.Domail.Markets.OkxExchange
{
    public class OkxExchange : CryptoExchange
    {
        public override async Task GetCurrenciesByAPI(string? apiKey = null, string? apiSecret = null)
        {
            throw new NotImplementedException();
        }

        public override async Task GetOnlyOneCurrencByAPI(string nameOfCurrenc, string? apiKey = null, string? apiSecret = null)
        {
            string url = "https://www.okx.com/api/v5/market/mark-price-candles?instId=BTC-USD-SWAP&limit=1";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                }
                else
                {
                    Console.WriteLine("Ошибка при выполнении запроса: " + response.StatusCode);
                }
            }
        }
    }
}

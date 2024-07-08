
namespace CryptoCactus.Domain.Markets.Abstract
{
    public class HttpConnector
    {
        public async Task<string> HttpConnect(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return responseBody;
                }
                else
                {
                    return response.StatusCode.ToString();
                }
            }
        }
    }
}

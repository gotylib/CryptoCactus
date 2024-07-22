using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CryptoCactus.Domain.Markets.OkxExchanges
{
    public class OkxResponseSerialaze
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("msg")]
        public string? Msg { get; set; }

        [JsonPropertyName("data")]
        public List<List<string>>? Data { get; set; }
    }



}

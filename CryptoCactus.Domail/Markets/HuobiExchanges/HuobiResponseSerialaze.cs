using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CryptoCactus.Domain.Markets.HuobiExchanges
{
    public class HuobiResponseSerialaze
    {
        [JsonPropertyName("ch")]
        public string ch { get; set; }

        [JsonPropertyName("status")]
        public string status { get; set; }

        [JsonPropertyName("ts")]
        public long ts { get; set; }

        [JsonPropertyName("tick")]
        public Tick tick { get; set; }

    }
    public class Tick
    {
        [JsonPropertyName("id")]
        public long id { get; set; }

        [JsonPropertyName("ts")]
        public long ts { get; set; }

        [JsonPropertyName("data")]
        public List<TradeData> data {get; set; }
    }

    public class TradeData
    {
        [JsonPropertyName("id")]
        public double id { get; set; }

        [JsonPropertyName("ts")]
        public long ts { get; set; }

        [JsonPropertyName("trade-id")]
        public long trade_id { get; set; }

        [JsonPropertyName("amount")]
        public double amount { get; set; }

        [JsonPropertyName("price")]
        public double price { get; set; }

        [JsonPropertyName("direction")]
        public string direction { get; set; }
    }

}

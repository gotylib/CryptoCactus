using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CryptoCactus.Domain.Markets.BingX
{
    public class BingXResponseSerialaze
    {
        public int code { get; set; }
        public string msg { get; set; }
        public MarketData data { get; set; }
    }
    public class MarketData
    {
        public string symbol { get; set; }
        public string price { get; set; }
        public long time { get; set; }
    }

}

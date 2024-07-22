using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCactus.Domain.Markets.BitGetExchanges
{
    public class BitGetResponseSerialaze
    {
        public string code { get; set; }
        public string msg { get; set; }
        public long requestTime { get; set; }
        public List<SymbolData> data { get; set; }
    }

    public class SymbolData
    {
        public string open { get; set; }
        public string symbol { get; set; }
        public string high24h { get; set; }
        public string low24h { get; set; }
        public string lastPr { get; set; }
        public string quoteVolume { get; set; }
        public string baseVolume { get; set; }
        public string usdtVolume { get; set; }
        public string ts { get; set; }
        public string bidPr { get; set; }
        public string askPr { get; set; }
        public string bidSz { get; set; }
        public string askSz { get; set; }
        public string openUtc { get; set; }
        public string changeUtc24h { get; set; }
        public string change24h { get; set; }
    }
}

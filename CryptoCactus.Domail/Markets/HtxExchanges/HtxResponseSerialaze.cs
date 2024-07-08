using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCactus.Domain.Markets.HtxExchanges
{
    public class HtxResponseSerialaze
    {
        public string Ch { get; set; }
        public string Status { get; set; }
        public long Ts { get; set; }
        public KlineData[] Data { get; set; }
    }

    public class KlineData
    {
        public long Id { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double Low { get; set; }
        public double High { get; set; }
        public double Amount { get; set; }
        public double Vol { get; set; }
        public long Count { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCactus.Domail.Markets.BybitExchanges
{
    public class BybitResponseSerialaze
    {
        public int retCode { get; set; }
        public string? retMsg { get; set; }
        public SubResponseSerialaze? result { get; set; }
        public Dictionary<string, object>? retExtInfo { get; set; }
        public long time { get; set; }
    }

    public class SubResponseSerialaze
    {
        public string? category { get; set; }
        public string? symbol { get; set; }
        public List<List<string>>? list { get; set; }
    }
}

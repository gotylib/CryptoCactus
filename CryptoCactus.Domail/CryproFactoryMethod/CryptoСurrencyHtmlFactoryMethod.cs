using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCactus.Domain.CryproFactoryMethod
{
    public class CryptoСurrencyHtmlFactoryMethod
    {
        public static string GenerateCryptoСurrencyHtml(string currency)
        {
            var resultHtml = new StringBuilder();
            string[] exchanges = { "Bybit", "Okx", "HTX", "BingX", "BitGet", "Kucoin", "Huobi" };
            resultHtml.AppendLine("<!DOCTYPE html>");
            resultHtml.AppendLine("<html>");
            resultHtml.AppendLine("<head>");
            resultHtml.AppendLine("<link rel=\"stylesheet\" href=\"tableStyle.css\">");
            resultHtml.AppendLine("<style>.fade-in { opacity: 0; animation: fadeIn ease-in 1; animation-fill-mode: forwards; animation-duration: 1s; } @keyframes fadeIn { 0% { opacity: 0; } 100% { opacity: 1; } }</style>");
            resultHtml.AppendLine("</head>");
            resultHtml.AppendLine("<body>");
            resultHtml.AppendLine($"<h1 class=\"fade-in\"><span class=\"blue\">&lt;</span>{currency}<span class=\"blue\">&gt;</span> <span class=\"yellow\">Price</span></h1>");
            resultHtml.AppendLine("<h2 class=\"fade-in\">Project EVA</h2>");

            resultHtml.AppendLine("<table class=\"container\"><thead><tr><th><h1>Exchange</h1></th><th><h1>Value</h1></th></tr></thead><tbody>");

            foreach (var exchange in exchanges)
            {
                resultHtml.AppendLine($"<tr class=\"row\"><td>{exchange}</td><td id=\"{exchange}\"></td></tr>");
            }

            resultHtml.AppendLine("</tbody></table>");

            resultHtml.AppendLine("<script src=\"https://cdnjs.cloudflare.com/ajax/libs/microsoft-signalr/6.0.1/signalr.js\"></script>");
            resultHtml.AppendLine("<script>");
            resultHtml.AppendLine("const hubConnection = new signalR.HubConnectionBuilder().withUrl(\"/chat\").build();");

            resultHtml.AppendLine("hubConnection.on(\"Receive\", function (data) {");

            for (int i = 0; i < exchanges.Length; i++)
            {
                resultHtml.AppendLine($"document.getElementById('{exchanges[i]}').innerText = data[{i}];");
            }

            resultHtml.AppendLine("});");
            resultHtml.AppendLine("hubConnection.start().catch(function (err) { return console.error(err.toString()); });");
            resultHtml.AppendLine("</script>");

            resultHtml.AppendLine("</body></html>");

            return resultHtml.ToString();
        }

    }
}

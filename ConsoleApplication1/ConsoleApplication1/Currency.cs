using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Currency
    {
        public string cc { get; set;}
        public string symbol { get; set;}
        public string name { get; set; }
        public string url { get; set; }

        public list<Currency> Currencies;

        public void CurrenciyleriCekVeAyristir()
        {
            string jsontext = new WebClient().DownloadString(url);

            Currencies = JsonConvert.DeserializeObject<List<Currency>>(jsontext);
        }

        public void VeriyiEkranaBas()
        { 
            foreach (var data in Currencies)
            {
                Console.WriteLine(data.cc+"\t"
                    + data.symbol + "\t"
                    +data.name);
            }
    }
}

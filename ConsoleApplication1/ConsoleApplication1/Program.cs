using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            task4();

            task5();
            Console.Read();
        }
        public static void task5()
        {
            Console.WriteLine("\n çevirmek istenilen döviz birimi giriniz.");
            string birimler = Console.ReadLine();
            try
            {
                string[] doviz = birimler.Split('-');
                string m = doviz[0];
                string d1 = doviz[1];
                string d2 = doviz[2];

                FixerI0 fix = new FixerI0
                {
                    url = "https://api.fixer.io/latest?base=" + d1
                };
                fix.CurrenciyleriCekVeAyristir();
                fix.CurrencyHesapla(int.Parse(m), d1, d2);
            }
            catch
            {
                Console.WriteLine("Yanlış Giriş Yapıldı!");
            }
        }
        public static void task4()
        {
            Currency currency = new Currency
            {
                url = "https://raw.githupusercontent.com/mhs/world-currencies/master/currencies.json"
            };
            currency.CurrenciyleriCekVeAyristir();

            currency.VeriyiEkranaBas();
        }
    }
}


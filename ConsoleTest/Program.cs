using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Przelewy24;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Przelewy24.Przelewy24 p24 = new Przelewy24.Przelewy24("49518", "49518", "d13be93f322c7ec3", true);
            


            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        public static async void Test()
        {

        }

        static void BuildUrl()
        {
            string sign = "97450210a805f88bcecf45866684497c";
            string merchantId = "15651";
            string sessionId = "miesiecznydostep-366";
            string amount = "1000";
            string currency = "PLN";
            string crc = "42542d9dcf6a1497";

            string[] s = { sessionId, merchantId, amount, currency, crc };

            Console.WriteLine("\n\r\n\r" + Przelewy24.Przelewy24.CalculateSign(s) + "\n\r\n\r");


            var result = Przelewy24InrernalTools.Crc.CrcHelper.FindBugInRegisterSign32(
                sign,
                merchantId,
                sessionId,
                amount,
                currency,
                crc
                );



            foreach (var r in result)
            {
                Console.WriteLine(r.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    internal class CurrencyExchange
    {
        public CurrencyExchange(CurrencyExchanger obj)
        {
            Console.Clear();

            Console.WriteLine("Select your source currency\n");
            obj.PrintCurrencies();
            int sourceCurrencyIndex = obj.SelectCurrency("Source");

            Console.WriteLine("Select your destination currency\n");
            obj.PrintCurrencies();
            int destinationCurrencyIndex = obj.SelectCurrency("Destination");

            Console.WriteLine("Enter your source currency amount");
            try
            {
                double sourceAmount = Convert.ToDouble(Console.ReadLine());

                double destinationAmount = obj.Currencies[sourceCurrencyIndex].ExchangeRate * sourceAmount / obj.Currencies[destinationCurrencyIndex].ExchangeRate;

                Console.WriteLine("\nFinally you have {0} {1}", obj.Currencies[destinationCurrencyIndex].ISO, Math.Round(destinationAmount, 4));
            }
            catch
            {
                Console.WriteLine("Invalid source amount");
            }

            Console.WriteLine("Press Backspace to back to the main menu\n");
            while (Console.ReadKey().Key != ConsoleKey.Backspace) { }
            obj.MainMenu();

        }
    }
}

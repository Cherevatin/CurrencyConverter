using System;

namespace CurrencyConverter
{
    internal class AddCurrency
    {

        private readonly CurrencyExchanger _currencyExchanger;

        public AddCurrency(CurrencyExchanger currencyExchanger)
        {
            _currencyExchanger = currencyExchanger;
        }

        public void ScenarioAddCurrency()
        {
            Console.Clear();
            Console.Write("Enter currency code:");

            string iso = "";

            while (true)
            {
                iso = Convert.ToString(Console.ReadLine());

                if (_currencyExchanger.ListISO.Contains(iso.ToUpper()))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Undefined code");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter exchange rate:");

                    double exchangeRate = Convert.ToDouble(Console.ReadLine());
                    var currency = new Currency(iso.ToUpper(), exchangeRate);

                    _currencyExchanger.AddCurrency(currency);

                    Console.WriteLine("\nNew currency has been added:");
                    Console.WriteLine(currency.ISO + " " + currency.ExchangeRate);
                    Console.WriteLine("\nPress Backspace to back to the main menu\n");

                    break;
                }
                catch
                {
                    Console.WriteLine("Exchange rate must be a number. Please try again.");
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Backspace) { }
            
            return;

        }
        
    }
}

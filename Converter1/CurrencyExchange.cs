using System;

namespace CurrencyConverter
{
    internal class CurrencyExchange
    {
        private CurrencyExchanger _currencyExchanger;

        public CurrencyExchange(CurrencyExchanger currencyExchanger)
        {
            _currencyExchanger = currencyExchanger;
        }

        public void ScenarioCurrencyExchange()
        {
            Console.Clear();

            Console.WriteLine("Select your source currency\n");
            _currencyExchanger.PrintCurrencies();

            int sourceCurrencyIndex = _currencyExchanger.SelectCurrency("Source");

            Console.WriteLine("Select your destination currency\n");
            _currencyExchanger.PrintCurrencies();

            int destinationCurrencyIndex = _currencyExchanger.SelectCurrency("Destination");

            Console.WriteLine("Enter your source currency amount");
            try
            {
                double sourceAmount = Convert.ToDouble(Console.ReadLine());

                double destinationAmount = _currencyExchanger.Currencies[sourceCurrencyIndex].ExchangeRate * sourceAmount / _currencyExchanger.Currencies[destinationCurrencyIndex].ExchangeRate;

                Console.WriteLine("\nFinally you have {0} {1}", _currencyExchanger.Currencies[destinationCurrencyIndex].ISO, Math.Round(destinationAmount, 4));
            }
            catch
            {
                Console.WriteLine("Invalid source amount");
            }

            Console.WriteLine("Press Backspace to back to the main menu\n");

            while (Console.ReadKey().Key != ConsoleKey.Backspace) { }

            return;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    internal class CurrencyExchanger
    {
        private List<Currency> currencies = new List<Currency>();

        public List<Currency> Currencies { get; set; }
        public CurrencyExchanger()
        {
            AddNewCurrency("USD", 26.71);
            AddNewCurrency("EUR", 31.45);
            MainMenu();
        }

        public void AddNewCurrency()
        {
            Console.Clear();
            Console.Write("Enter currency code:");
            string iso = Console.ReadLine();
            Console.Write("Enter exchange rate:");
            double exchangeRate = Convert.ToDouble(Console.ReadLine());
            var currency = new Currency(iso, exchangeRate);
            Currencies.Add(currency);
            Console.WriteLine("\nNew currency has been added:");
            currency.Print();
            Console.WriteLine("\nPress Backspace to back to the main menu\n");
            while (Console.ReadKey().Key != ConsoleKey.Backspace) { }
            MainMenu();

        }
        public void AddNewCurrency(string ISO, double ExchangeRate)
        {
            var currency = new Currency(ISO, ExchangeRate);
            Currencies.Add(currency);
        }

        public void PrintCurrencies()
        {
            foreach (var currency in currencies)
            {
                Console.WriteLine("{0}. {1} {2}", Currencies.IndexOf(currency) + 1, currency.ISO, currency.ExchangeRate);
            }
        }

        public int SelectCurrency(string selectionType)
        {
            Console.WriteLine("\nType appropriate digit to select currency");
            while (true)
            {
                try
                {
                    int select = Convert.ToInt32(Console.ReadLine());
                    if (select > 0 && select < Currencies.Capacity)
                    {
                        Console.WriteLine(selectionType + " currency selected: ");
                        Currencies[select - 1].Print();
                        return select - 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number. Try again please");
                }
            }
        }

        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Available currencies\n");
            PrintCurrencies();

            Console.WriteLine("\n1. Exchange the currency\n2. Add new currency\n3. Exit");

            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        _ = new CurrencyExchange(this);
                        break;
                    case ConsoleKey.D2:
                        AddNewCurrency();
                        break;
                    case ConsoleKey.D3:
                        return;
                    default:
                        Console.WriteLine("Unknown choice");
                        break;
                }
            }
        }
    }
}

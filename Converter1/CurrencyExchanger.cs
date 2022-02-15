using System;
using System.Collections.Generic;

namespace CurrencyConverter
{
    internal class CurrencyExchanger
    {
        public List<string> ListISO
        {
            get;
            private set;
        }

        public List<Currency> Currencies {
            get;
            private set; 
        }
        public CurrencyExchanger()
        {
            Currencies = new List<Currency>();
            
            Currencies.Add(CreateCurrency("USD", 26.71));
            Currencies.Add(CreateCurrency("EUR", 31.45));

            ListISO = new List<string>()
            {
                "USD",
                "EUR",
                "RUB",
                "UAH",
                "GBP",
                "JPY",
                "CHF",
                "CNY"
            };
        }

        public void PrintCurrencies()
        {
            foreach (var currency in Currencies)
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
                    if (select > 0 && select <=Currencies.Count)
                    {
                        Console.WriteLine(selectionType + " currency selected: ");
                        Console.WriteLine(Currencies[select - 1].ISO + " " + Currencies[select - 1].ExchangeRate);
                        return select - 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number. Try again please");
                }
            }
        }

        public Currency CreateCurrency(string ISO, double ExchangeRate)
        {
            return new Currency(ISO, ExchangeRate);
        }

        public void AddCurrency(Currency currency)
        {
            Currencies.Add(currency);
        }
    }
}

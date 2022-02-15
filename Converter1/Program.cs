using System;

namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrencyExchanger exchanger1 = new CurrencyExchanger();
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Available _currencies\n");

                exchanger1.PrintCurrencies();

                Console.WriteLine("\n1. Exchange the currency\n2. Add new currency\n3. Exit");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:

                        var exchangeScenario = new CurrencyExchange(exchanger1);

                        exchangeScenario.ScenarioCurrencyExchange();
                        break;

                    case ConsoleKey.D2:

                        var addScenario = new AddCurrency(exchanger1);

                        addScenario.ScenarioAddCurrency();
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

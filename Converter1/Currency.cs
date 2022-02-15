using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    internal class Currency
    {
        public string ISO { get; set; }
        public double ExchangeRate { get; set; }
        public Currency(string ISO, double ExchangeRate)
        {
            this.ISO = ISO;
            this.ExchangeRate = ExchangeRate;
        }
        public void Print()
        {
            Console.WriteLine("{0} {1}", ISO, ExchangeRate);
        }
    }
}

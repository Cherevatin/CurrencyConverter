namespace CurrencyConverter
{
    internal class Currency
    {
        public string ISO { get; private set; }

        public double ExchangeRate { get; private set; }

        public Currency(string iso, double exchangeRate)
        {
            ISO = iso;
            ExchangeRate = exchangeRate;
        }
    }
}

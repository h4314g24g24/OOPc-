using System;


namespace OOPhm1
{
    public class Converter
    {
        public double UsdRate { get; }
        public double EurRate { get; }
        public double GBPRate { get; }

        public Converter(double usd, double eur, double GBP)
        {
            UsdRate = usd;
            EurRate = eur;
            GBPRate = GBP; // замінив на фунти  
        }

        public double ConvertFromUAH(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount / UsdRate;
                case "eur":
                    return amount / EurRate;
                case "GBP":
                    return amount / GBPRate;
                default:
                    throw new ArgumentException("Unknown currency.");
            }
        }

        public double ConvertToUAH(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount * UsdRate;
                case "eur":
                    return amount * EurRate;
                case "GBP":
                    return amount * GBPRate;
                default:
                    throw new ArgumentException("Unknown currency.");
            }
        }





    }
}

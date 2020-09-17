using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Converter
    {
        double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void ConvertToUsd(double rubSum)
        {
            Console.WriteLine("RUB = {0}, USD = {1}, RUB to USD: {2}", rub, usd, rubSum / usd);
        }

        public void ConvertToEur(double rubSum)
        {
            Console.WriteLine("RUB = {0}, EUR = {1}, RUB to EUR: {2}", rub, eur, rubSum / eur);
        }

        public void ConvertFromUsd(double usdSum)
        {
            Console.WriteLine("USD = {0}, RUB = {1}, USD to RUB: {2}", usd, rub, usdSum / usd);
        }

        public void ConvertFromEur(double usdSum)
        {
            Console.WriteLine("EUR = {0}, RUB = {1}, EUR to RUB: {2}", eur, rub, usdSum / eur);
        }
    }
}

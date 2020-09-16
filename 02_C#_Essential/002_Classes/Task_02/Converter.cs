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

        public double Usd { set; get; }
        public double Eur { set; get; }
        public double Rub { set; get; }
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = usd;
            this.rub = usd;
        }

        public void ConvertToUsd()
        {
            Console.WriteLine("RUB = {0}, USD = {1}: ", rub, usd);
        }
        public void ConvertToEur()
        {
            Console.WriteLine("RUB = {0}, EUR = {1}: ", rub, eur);
        }
        public void ConvertToRub()
        {
            if (eur)
            {
                Console.WriteLine("EUR = {0}, rub = {1}: ", eur, rub);
            }
            
            Console.WriteLine("USD = {0}, rub = {1}: ", usd, rub);
        }
    }
}

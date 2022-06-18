using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int monthDeposit = int.Parse(Console.ReadLine());
            double gdp = double.Parse(Console.ReadLine());
            double gdpInPercent = gdp / 100;

            double sum = depositSum + monthDeposit * ((depositSum * gdpInPercent) / 12);

            Console.WriteLine($"{sum}");


        }


    }
}

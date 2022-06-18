using System;

namespace _04._Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPagesInBook = int.Parse(Console.ReadLine());
            double numPagesForHour = double.Parse(Console.ReadLine());
            int numDays = int.Parse(Console.ReadLine());

            double timeToReadook = numPagesInBook / numPagesForHour;
            double hoursNeede = timeToReadook / numDays * 1.0;
            Console.WriteLine($"{hoursNeede}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_TRIANGLE_AREA
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double width = Math.Abs(x1 - x2);
            double height = Math.Abs(y1 - y2);
            double area = width * height;
            double perimeter = 2 * (width + height);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);

        }
    }
}

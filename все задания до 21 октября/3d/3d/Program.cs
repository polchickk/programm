using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3d
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = InputCoordinate("абсциссу");
            var y = InputCoordinate("ординату");

            Console.WriteLine(IsInsideArea(x,y));
        }
        static bool IsInsideArea(double x, double y)
        {
            return 0 <= x && x <= 1 && 0 <= y && y <= 1 && !(x * x + (y - 1) * (y - 1) >= 1 && (x - 1) * (x - 1) + y * y >= 1);
        }
        static double InputCoordinate(string name)
        {
            Console.WriteLine($"Введите {name} точки");
            return double.Parse(Console.ReadLine());
        }
        
    }

}

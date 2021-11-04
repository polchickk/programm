using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение х: ");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Полученное значение фунцкии:" + Function(x));
            Console.ReadKey();
        }
        static double Function(double x)
        {
            if (x < -2)
                return Math.Sqrt(x * x + 4);
            if (x > 1)
                return Math.Sqrt(x * x - 1);
            else
                return 1 / (x * x + 1);
                
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное значение аргумента");
            var x0 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение шага");
            var step = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число строк таблицы");
            var n = int.Parse(Console.ReadLine());

            PrintHeader("x^2");

            for (var i = 0; i < n; i++)
            {
                var arg = x0 + step * i;
                Console.WriteLine($"{arg,5:F2} | {arg * arg:F3}");
               
            }

            PrintHeader("sin x");

            for (var i = 0; i < n; i++)
            {
                var arg = x0 + step * i;
                Console.WriteLine($"{arg,5:F2} | {Math.Sin(arg):F3}");
               
            }

            Console.ReadKey();

        }

        private static void PrintHeader(string functionName)
        {
            Console.WriteLine($" x   | {functionName}");
            Console.WriteLine(new string('-', 15));
        }
    }
}

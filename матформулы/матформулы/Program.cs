using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace матформулы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольную переменную");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine(printy(x));

            Console.ReadKey();


        }

        private static double printy(double x)
        {
            return 2 * (Math.Sin(Math.Sqrt(x * x + 4) / 2) * Math.Cos(Math.Sqrt(x * x + 1) / 2));
        }



    }
}

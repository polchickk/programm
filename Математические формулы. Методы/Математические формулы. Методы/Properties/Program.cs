using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Математические_формулы.Методы
{
    class Program
    {
        static void Main(string[] args)
  
        {
            Console.WriteLine("Введите произвольную переменную");
            var x = double.Parse(Console.ReadLine());
            printf(x);
            
            Console.ReadKey();


        }

        private static double printf(double x)
        {
            return 2 * (Math.Sin(Math.Sqrt(x * x + 4) / 2) * Math.Cos(Math.Sqrt(x * x + 1) / 2));
            Console.ReadKey();
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskk3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите перменную ");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите перменную ");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите перменную ");
            var c = double.Parse(Console.ReadLine());
            double resA = (a + b + c) / 3;
            double resG =Math.Pow((a * b * c), (1.0 / 3.0));
            Console.WriteLine($"Среднее арефметическое данных трех чисел = " + resA);
            Console.WriteLine($"Среднее геометрическое данных трех чисел = " + resG);
            Console.ReadKey();
        } 
    }
}

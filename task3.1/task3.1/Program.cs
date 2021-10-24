using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите перменную ");
            var  a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите перменную ");
            var  b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите перменную ");
            var  c = double.Parse(Console.ReadLine());
            var resA = (a+b+c)/3;
            var resG = Math.Pow((a * b * c),1/3);
            Console.WriteLine($"Среднее арефметическое данных трех чисел = " + resA);
            Console.WriteLine($"Среднее геометрическое данных трех чисел = " + resG);
            Console.ReadKey();
            
        }
    }
}

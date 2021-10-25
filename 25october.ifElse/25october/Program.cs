using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25october
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату x = ");
            var x = double.Parse(Console.ReadLine());
            Console.Write("Введите координату y = ");
            var y = double.Parse(Console.ReadLine());

            if (x == 0)
                if (y == 0)
                    Console.Write($"Точка({x};{y}) совпадает с началом координат ");
                else
                    Console.Write($"Точка({x};{y}) лежит на оси Oy");
            else
                if (y == 0)
                    Console.Write($"Точка({x};{y}) лежит на оси Ox");
                else
                    if (x > 0)
                        if (y > 0)
                            Console.WriteLine($"Точка({x};{y}) лежит в I квадранте");
                        else
                            Console.WriteLine($"Точка({x};{y}) лежит в IV квадранте");
                    else
                        if (y > 0)
                            Console.WriteLine($"Точка({x};{y}) лежит  вo II квадранте");
                        else
                            Console.WriteLine($"Точка({x};{y}) лежит в III квадранте");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3b
{
    class Program
    {
        static void Main(string[] args)
        {

            var x = Input("x");
            var y = Input("y");
            var z = Input("z");
            Console.WriteLine(IsOnlyOneNumberDevidedByFive(x,y,z));


            Console.ReadKey();

        }
        static int Input(string name)
        {
            Console.WriteLine($"введите целое число {name}");
            return int.Parse(Console.ReadLine());

        }
        static bool IsOnlyOneNumberDevidedByFive(int x,int y, int z)
        {
            var a = IsDevivedBy5(x);
            var b = IsDevivedBy5(y);
            var c = IsDevivedBy5(z);
            return a && b && !c || !a && b && c || a && !b && c;
        }
        static bool IsDevivedBy5(int number)
        {
            return number % 5 == 0;
        }
    }
}

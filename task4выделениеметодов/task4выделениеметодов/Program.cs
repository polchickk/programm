using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4выделениеметодов
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(RoundedResult());

            Console.ReadKey();
        }

        private static double RoundedResult()
        {
            return Math.Round(SumOfSin(2, 3) / SumOfCos(2, 3) + (SumOfCos(5, 7)) / SumOfSin(5, 7), 3);
        }

        static double SumOfCos(int x, int y)
        {
            return (Math.Cos(x) + Math.Cos(y));
        }

        static double SumOfSin(int x, int y)
        {

            return sin(x) + sin(y);

        }
        static double sin(int s)
        {

            return Math.Sin(s);

        }
        static double cos(int s)
        {

            return Math.Cos(s);
        }
    }
}


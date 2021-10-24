using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = GetResult();
            Console.WriteLine("GetResult= {0:F3}", d);
            Console.ReadKey();
        }
        private static double GetResult()
        {
            return CalculateExpression(2, 3) + 1/CalculateExpression(5, 7);
        }
        static double CalculateExpression(double x, double y)
        {
           return (Math.Sin(x) + Math.Sin(y)) / (Math.Cos(x) + Math.Cos(y));
        }
    }
}

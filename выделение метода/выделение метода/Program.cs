using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace выделение_метода
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((Math.Sin(a) + Math.Sin(b)) / (Math.Cos(c) + Math.Cos(3)) + (Math.Cos(5) + Math.Cos(7)) / (Math.Sin(5) + Math.Sin(7)) , 3));
            
            Console.ReadKey();
        }
    }
}

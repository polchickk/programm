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
           var  a = Console.ReadLine();
            int a1 = Convert.ToInt32(a);
            var b = Console.ReadLine();
            int b1 = Convert.ToInt32(b); 
            var c = Console.ReadLine();
            int c1 = Convert.ToInt32(c);
            var resA = (a1+b1+c1)/3;
            var resG = (a1 * b1 * c1) / 3;
            Console.WriteLine( resA);
            Console.WriteLine( resG);
            Console.ReadKey();
            
        }
    }
}

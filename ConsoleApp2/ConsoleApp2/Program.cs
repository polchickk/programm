using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ");
            var symbol = Console.ReadLine()[0];
           
            Console.WriteLine($" Символ \'{symbol}\'");
            Console.ReadKey();     
            
        }
    }
}

﻿using System;
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
           
            Console.WriteLine($" Символ \'{symbol}\': 0x{Convert.ToString((int)symbol,16).ToUpper()}");
            Console.ReadKey();     
            
        }
    }
}

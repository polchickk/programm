using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задачи11окт
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    Console.WriteLine(GetHalfString("Hello, world"));
        //    Console.WriteLine(GetHalfString(""));
        //    Console.WriteLine(GetHalfString("a b c d"));
        //    Console.WriteLine("\n Задача 2 \n");
        //    Console.WriteLine("Введите температуру в градусах по цельсию" );
        //    var Cel = double.Parse(Console.ReadLine());
        //    var far = gradvfar(Cel);
        //    Console.WriteLine($"Температура {Cel:F1} в гр по цельсию в фаренгейте {far:F1}");
        Console.WriteLine( "\n Задача 3 \n" );
        Console.WriteLine("Введите адрес электронной почты ");
        var email = Console.ReadLine();
        var index = email.IndexOf('@');
        var mailbox = email.substring(0,index);
        var mailservice= email.Substring(index + 1);
        Console.WriteLine($"Ваш почтовый ящик {mailbox} находится на почтовом сервисе {mailservice}");
            Console.ReadKey();
        }
        
    static string GetHalfString(string fullString)
        {
            var s = fullString.Replace(" ", "");
            return s.Substring(s.Length / 2);

         }
        static double gradvfar(double cel)
        {

            return cel * 1.8 + 32;
        }
    }
}

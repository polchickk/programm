using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charAndStrings
{
    class Program
    {
        static void Main()
        {
            char ch = 'z';
            Console.WriteLine(ch);
           
            ch = (char)0x42F;
            Console.WriteLine(ch);
            
            //char.ToLower(ch); не изменяет исходный символ
            Console.WriteLine(char.ToLower(ch));
            Console.WriteLine(char.IsLower(ch));

            string str = "";//пустая строка
            str = string.Empty;
            str = "Hello, world!";
            ch = str[7];
            Console.WriteLine(ch);
            // ch = str[-1]; не работает

            Console.WriteLine(str.Length);
            Console.WriteLine(str.IndexOf("o"));
            Console.WriteLine(str.IndexOf("world"));// начало строки
            Console.WriteLine(str.LastIndexOf("o"));// последняя встречающаяся буква
            Console.WriteLine(str.Substring(8, 2));
            Console.WriteLine(str.Substring(7));


            string result = str.Substring(4, 1).ToUpper() + str.Substring(0, 1).ToLower
                + str.Substring(5, 2) + str.Substring(2, 1).ToUpper() + str.Substring(8, 2) + str.Substring(11, 2);
            Console.WriteLine(result);



            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)

        static void Main()
        {
            //1.запрос 2 целых 1-байтовых числа и вывод на консоль значения лог операций над ними. ввод произвести в 16-щй сс.
            //вывод чисел и результатов операций в 2 - ой сс.
              Console.WriteLine("введите двузначное число в 16-й системе счисления: ");
            byte x = Convert.ToByte(Console.ReadLine(), 16);

            Console.WriteLine("введите еще одно двузначное число в 16-й системе счисления: ");
            byte y = Convert.ToByte(Console.ReadLine(), 16);

            Console.WriteLine($"x = {Convert.ToString(x, 2)}");//в двоичную сс
            Console.WriteLine($"y = {Convert.ToString(y, 2)}");

            Console.WriteLine($"~x = {Convert.ToString(~x, 2).Substring(24)}");//в двоичную сс
            Console.WriteLine($"~y = {Convert.ToString(~y, 2).Substring(24)}");
            Console.WriteLine($"x&y = {Convert.ToString(x & y, 2)}");
            Console.WriteLine($"x ^ y = {Convert.ToString(x ^ y, 2)}");
            Console.WriteLine($"x | y = {Convert.ToString(x | y, 2)}");
            //2. написать метод, вычисляющий лог выражение "неверно, что x>0 и x<5"
            Console.WriteLine("введите значение p: ");

            var p = Double.Parse(Console.ReadLine());

            Console.WriteLine(IsItTrue(p));
            Console.WriteLine("Hello, world!!!!");

            Console.ReadKey();
        }
        static bool IsItTrue(double p)
        {
            return !(p > 0 && p < 5);
        }
    }   
       
}

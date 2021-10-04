using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4октября
{
    class Program
    {
        static void Main(string[] args)
        {
            //var l = Math.PI/12;
            // var sinl = Math.Sin(l);
            // var f= Math.PI / 180*37;
            // var sinf = Math.Sin(f); 
            // var r = Math.PI / 180*113;
            // var sinr = Math.Sin(r);
            // var a = Console.ReadLine();
            // int a1 = Convert.ToInt32(a);
            // var a2 = Math.PI / 180*a1;
            // var sina = Math.Sin(a2);
            // Console.WriteLine("синус 15 = "+ sinl+ ", синус 37 =" + sinf + ", синус 113 =" + sinr + ", синус " + a2 + "=" + sina);

            // Console.ReadKey();


            //Console.WriteLine(Math.Round(Math.Sin(15 * Math.PI / 180), 3));
            //Console.WriteLine(Math.Round(Math.Cos(15 * Math.PI / 180), 3));

            //Console.WriteLine(Math.Round(Math.Sin(113 * Math.PI / 180), 3));
            //Console.WriteLine(Math.Round(Math.Cos(113 * Math.PI / 180), 3));
            //Console.WriteLine(Math.Round(Math.Sin(37 * Math.PI / 180), 3));

            //Console.WriteLine(Math.Round(Math.Cos(37 * Math.PI / 180), 3));

            printsincos(15);
            printsincos(37);
            printsincos(113);
            Console.WriteLine("Введите производный угол в градусах");
            var angleInDegrees = double.Parse(Console.ReadLine());
            printsincos(angleInDegrees);
            
            Console.ReadKey();

        }

         static void printsincos(double angleIndeg)
        {
            var angleInRad = converDegtoRad(angleIndeg);
            Console.WriteLine("sin " + angleIndeg + "° = " + CalculateRoundSin(angleInRad));
            Console.WriteLine("cos " + angleIndeg + "° = " + CalculateRoundCos(angleInRad));
        }

        private static double CalculateRoundCos(double angleInRad)
        {
            return Math.Round(Math.Cos(angleInRad), 3);
        }

        private static double CalculateRoundSin(double angleInRad)
        {
            return Math.Round(Math.Sin(angleInRad), 3);
        }

        private static double converDegtoRad(double x)
        {
            return x * Math.PI / 180;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 2;

            const double g=9.8;
            Console.WriteLine(g);
            Console.WriteLine(m);
            Console.WriteLine(m++ + ++m);
            var x = 2;

            double angle = Math.PI / 6;
            double sinus = Math.Sin(angle);
            Console.WriteLine(sinus);
            //неявная конверсия:

            angle = x;
            //double стал int
            //явная конверсия:
            //(имя_типа)имяПеременной
            x = (int)Math.Pow(2, 3);
            Console.WriteLine(x);
            Console.WriteLine(angle);
        }
    }
}

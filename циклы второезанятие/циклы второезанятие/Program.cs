using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace циклы_второезанятие
{
    class Program
    {
        static void Main(string[] args)
        {
            const ulong UpperBound = ulong.MaxValue / 2;
            var p = (ulong)2;
            var power = (ulong)2;
            

            while(power < UpperBound)
            {
                power *=2;
                var mp = power-1;

                if(IsPrime(p)&& IsPrime(mp))
                    Console.WriteLine($"p={p} Mp={mp}");

                p++;
            }

            Console.ReadKey();
        }
        static bool IsPrime(ulong number)
        {
            var d = (ulong)2;
            while (d < Math.Sqrt(number))
            {
                if(number % d == 0)
                    return false;

                d++;
            }
            return true;

        }
    }
}

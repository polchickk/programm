using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace одиннадцатоеоктября
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCulture(CultureInfo.CurrentCulture.Name);
            TestCulture("en-US");
            TestCulture("cz-CZ");
            Console.ReadKey();
        }
        static void TestCulture(string cultureName)
        {
            var oldCulture = CultureInfo.CurrentCulture;
           CultureInfo.CurrentCulture = new CultureInfo(cultureName);

            Console.WriteLine(new string('=', 15));

            Console.WriteLine($"{ CultureInfo.CurrentCulture.Name}:{ CultureInfo.CurrentCulture.DisplayName }");
            Console.WriteLine(2.5);

            var date = DateTime.Now;
            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(new string('=', 30));
            CultureInfo.CurrentCulture = oldCulture;
        }
    }

}

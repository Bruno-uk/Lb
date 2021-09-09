using System;
using System.Globalization;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo
            {
                NumberDecimalSeparator = ".",
            };
            
            double v1, v2,a,s;
            Console.WriteLine("Write v1");
            str= Console.ReadLine();
            v1=Convert.ToDouble(str, numberFormatInfo);

            Console.WriteLine("Write v2");
            str = Console.ReadLine();
            v2 = Convert.ToDouble(str, numberFormatInfo);

            Console.WriteLine("Write a");
            str = Console.ReadLine();
            a = Convert.ToDouble(str, numberFormatInfo);

            Console.WriteLine("Write s");
            str = Console.ReadLine();
            s = Convert.ToDouble(str, numberFormatInfo);
            
            
            double res = (s*a)/(v1 + v2);
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}

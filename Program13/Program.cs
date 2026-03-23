using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, min;

            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            c = Convert.ToInt32(Console.ReadLine());

            min = (a < b) ?
                  ((a < c) ? a : c)
                  :
                  ((b < c) ? b : c);

            Console.WriteLine("Minimum number is: " + min);
        }
    }
}
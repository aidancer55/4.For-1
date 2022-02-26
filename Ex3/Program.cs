using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 0;
            while (A >= C)
            {
                a++;
                A = A - C;
            }
            while (B >= C)
            {
                b++;
                B = B - C;
            }

            Console.WriteLine("Количество квадратов {0}", a * b);
            Console.ReadKey();
        }
    }
}
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
            int a = 0;
            int b = 0;
            int N;
            do
            {
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                {
                    a++;
                }
                else if (N < 0)
                {
                    b++;
                }
            } while (N > 0 || N < 0);


            if (a > b)
            {
                Console.WriteLine("Положительных чисел больше");
            }
            else if (b > a)
            {
                Console.WriteLine("Отрицательных чисел больше");
            }
            else
            {
                Console.WriteLine("Число 0");
            }
            Console.ReadKey();
        }
    }
}
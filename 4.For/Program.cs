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
            int N = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            int a = 0;
            for (; n <= N; n++)
            {
                a = a + 2 * n - 1;
                Console.WriteLine("Квадрат числа {0} равен {1}", n, a);
            }
            Console.ReadKey();
        }
    }
}

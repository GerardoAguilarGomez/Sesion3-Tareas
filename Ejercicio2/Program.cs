using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 32;
            double a = 3.2;
            char c = 'a';

            Console.WriteLine("Variable N={0}", n);
            Console.WriteLine("Variable A={0}", a);
            Console.WriteLine("Variable C={0}", c);
            Console.WriteLine("{0}+{1}={2}", n, a, n + a);
            Console.WriteLine("{0}-{1}={2}", a, n, a - n);
            Console.WriteLine(Convert.ToInt32(c));
        }
    }
}

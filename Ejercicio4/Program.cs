using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9;

            Console.WriteLine("Valor inicial variable n: {0}", n);
            n = n + 77;
            Console.WriteLine("N+77={0}",n);
            n = n - 3;
            Console.WriteLine("N-3={0}", n);
            n = n * 2;
            Console.WriteLine("Nx2={0}", n);
        }
    }
}

using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 32;
            int y = 21;

            double m = 23.1;
            double n = 2.4;

            Console.WriteLine("Variable x={0}", x);
            Console.WriteLine("Variable y={0}", y);
            Console.WriteLine("Variable m={0}", m);
            Console.WriteLine("Variable n={0}", n);

            Console.WriteLine("{0}+{1}={2}", x, y, x + y);
            Console.WriteLine("{0}-{1}={2}", x, y, x - y);
            Console.WriteLine("{0}x{1}={2}", x, y, x * y);
            Console.WriteLine("{0}/{1}={2}", x, y, x / y);
            Console.WriteLine("{0}%{1}={2}", x, y, x % y);

            Console.WriteLine("{0}+{1}={2}", m, n, m + n);
            Console.WriteLine("{0}-{1}={2}", m, n, m - n);
            Console.WriteLine("{0}x{1}={2}", m, n, m * n);
            Console.WriteLine("{0}/{1}={2}", m, n, m / n);
            Console.WriteLine("{0}%{1}={2}", m, n, m % n);

            Console.WriteLine("{0}+{1}={2}", x, n, x + n);
            Console.WriteLine("{0}/{1}={2}", y, m, y / m);
            Console.WriteLine("{0}%{1}={2}", y, m, y % m);

            Console.WriteLine("El doble de {0} es {1}",x,x*2);
            Console.WriteLine("El doble de {0} es {1}", y, y * 2);
            Console.WriteLine("El doble de {0} es {1}", m, m * 2);
            Console.WriteLine("El doble de {0} es {1}", n, n * 2);

            Console.WriteLine("{0}+{1}+{2}+{3}={4}",x,y, m, n, x+y+m + n);
            Console.WriteLine("{0}x{1}x{2}x{3}={4}", x, y, m, n, x * y * m * n);
        }
    }
}

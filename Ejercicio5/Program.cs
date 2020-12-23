using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c = 7;
            int d = 9;

            Console.WriteLine("La variable a es igual a {0}", a);
            Console.WriteLine("La variable b es igual a {0}", b);
            Console.WriteLine("La variable c es igual a {0}", c);
            Console.WriteLine("La variable d es igual a {0}", d);

            b = c;
            c = a;
            a = d;
            d = b;

            Console.WriteLine("La variable a es igual a {0}", a);
            Console.WriteLine("La variable b es igual a {0}", b);
            Console.WriteLine("La variable c es igual a {0}", c);
            Console.WriteLine("La variable d es igual a {0}", d);
        }
    }
}

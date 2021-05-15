using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial(3, 7);
        }

        static void Factorial(int n, int m)
        {
            int s = n;
            if (n <= m)
            {
                n++;
                s += n;
                Factorial(n, m);
            }
            else
            {
                Console.WriteLine(s);
            }
        }
    }
}

using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(15, 32, 7);
        }
        static void Calculate(int x, int y, int z)
        {
            Console.WriteLine(x / 5);
            Console.WriteLine(y / 5);
            Console.WriteLine(z / 5);
        }
    }
}

using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank(200, 100);
        }

        static void Bank(int x, int cash)
        {
            Console.WriteLine("Summa borg = ", x, "Your cash = ", cash, "Write your value pay");
            int money = int.Parse(Console.ReadLine());
            if (x - money >= 0)
            {
                x -= money;
                cash -= money;
                Console.WriteLine($"Your borg = {x} Your cash before zar = {cash}");
                cash += 100;
                Bank(x, cash);
            }
            else
            {
                Console.WriteLine($"Your borg = {(x-money)} Your cash = {cash}");
            }
        }
    }
}

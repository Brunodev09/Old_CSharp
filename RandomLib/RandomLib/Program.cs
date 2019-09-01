using System;

namespace RandomLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int num;

            for (int i = 0; i < 10; i++)
            {
                num = dice.Next(1, 7);
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}

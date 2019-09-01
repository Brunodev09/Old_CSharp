using System;

namespace MathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Ceiling(10.2));
            Console.WriteLine(Math.Floor(10.2));

            int num = 13;
            int num2 = 5;

            Console.WriteLine(Math.Min(num, num2));
            Console.WriteLine(Math.Max(num, num2));

            Console.WriteLine(Math.Pow(2,2));

            Console.WriteLine(Math.PI);

            Console.WriteLine(Math.Sqrt(25));

            Console.WriteLine(Math.Abs(-10));

            Console.WriteLine(Math.Cos(1));

            Console.ReadKey();
        }
    }
}

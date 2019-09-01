using System;
using System.Collections.Generic;

namespace Lambda
{
    class Program
    {

        public delegate int someMath(int i);
        public delegate bool Compare(int i, Number n);

        static void Main(string[] args)
        {
            doSomething();
        }

        public static void doSomething()
        {
            someMath math = new someMath(Square);
            Console.WriteLine(math(2));

            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            // anonymous callback function 
            // FindAll is like .filter() from Javascript
            List<int> evenList = list.FindAll(delegate (int i)
            {
                return (i % 2 == 0);
            });

            foreach(int item in evenList)
            {
                Console.WriteLine(item);
            }
            // Lambda expression, just like arrow functions in Javascript
            List<int> oddList = list.FindAll(i => i % 2 == 1);
            oddList.ForEach(i => Console.WriteLine(i));

            Compare comp = (a, number) => a == number.n;
            Console.WriteLine(comp(5, new Number { n = 5 }));

            Console.ReadKey();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Square(int i)
        {
            return i * i;
        }
    }

    public class Number
    {
        public int n { get; set; }
    }
}

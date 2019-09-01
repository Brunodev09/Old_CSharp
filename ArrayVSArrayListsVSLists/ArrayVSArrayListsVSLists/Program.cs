using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayVSArrayListsVSLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 1, 2, 3, 4 };

            // Lists are limited to one type. Use it as much as you can to keep code consistent
            List<int> list = new List<int> { 1, 2, 3, 4 };
            list.Add(0);
            list.Add(38);
            list.Sort();

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add("oi");
            array.Add(new Number { n = 400 });

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            
        }
    }

    class Number
    {
        public int n { get; set; }

        // Needs to be converted to be able to be accessed correctly from ArrayList
        public override string ToString()
        {
            return n.ToString();
        }
    }
}

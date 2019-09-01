using System;
using System.IO;

namespace TextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // In C#, if there is no undefined, needs to be attributed to something before used anywhere
            string text = null;
            string[] lines = null;
            string[] wlines = { "first", "second", "third"};

            try
            {
                text = File.ReadAllText(@"C:\tmp\text.txt");

            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
            if (text != null)
            {
                Console.WriteLine("File contains --> " + text);
            }
            try
            {
                lines = File.ReadAllLines(@"C:\tmp\text.txt");
                foreach (var line in lines)
                {
                    if (line != null) Console.WriteLine("\t" + line);
                }
            } catch(Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
            
            try
            {
                File.WriteAllLines(@"C:\tmp\text.txt", wlines);
            } catch(Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }

            Console.ReadKey();

            using (StreamWriter stream = new StreamWriter(@"C:\tmp\text.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("third")) stream.WriteLine(line);
                }
            }

        }
    }
}

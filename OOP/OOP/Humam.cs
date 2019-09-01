using System;
namespace OOP_1
{
    public class Human
    {
        private int age;
        private string name;

        public Human()
        {
            Console.WriteLine("Default non overloaded constructor called.");
        }

        public Human(string age)
        {
            this.age = Conversion(age);
            this.name = "Bob";
        }
        public Human(string age, string name)
        {
            this.age = Conversion(age);
            this.name = name;
        }
        public int getAge()
        {
            return this.age;
        }
        public void Speak()
        {
            if (age != null && name != null)
            {
                if (age >= 2) Console.WriteLine("I'm human, my name is " + this.name + " and I can speak!");
                else Console.WriteLine("gugu-dada <--- baby speech");
            }
        }
        private int Conversion(string age)
        {
            try
            {
                return Int32.Parse(age);
            }
            catch (Exception)
            {
                Console.Write("Error in conversion!");
                return 1;
            }
        }
    }
}
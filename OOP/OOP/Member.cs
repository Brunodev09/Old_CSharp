using System;
namespace OOP_1
//use namespaces like in C++ so that we can control the scope of what we can access in each class
{
    public class Member
    {
        private int id;

        public Member(int id)
        {
            this.id = id;
        }
        public void getID()
        {
            Console.WriteLine(id);
        }
        ~Member()
        {
            //cleanup statements goes here
            Console.WriteLine("Deconstructor evoked!");
        }
    }
}
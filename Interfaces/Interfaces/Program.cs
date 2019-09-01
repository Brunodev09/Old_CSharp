using System;

namespace Interfaces
{

    public interface INotifications
    {
        // Just a blueprint for classes
        void showNotification();
        string getDate();
    }

    public class Notification : INotifications
    {
        private string sender;
        private string message;
        private string date;
        
        public Notification()
        {
            this.sender = "null";
            this.message = "null";
            this.date = "null";
        }

        public Notification(string sender, string myMessage, string myDate)
        {
            this.sender = sender;
            this.message = myMessage;
            this.date = myDate;
        }

        public string getDate()
        {
            return date;
        }

        public void showNotification()
        {
           
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

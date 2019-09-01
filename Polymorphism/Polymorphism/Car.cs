using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // has a relationship
        protected CarInfo carIdInfo = new CarInfo();

        public void SetCarInfo(int idNum, string owner)
        {
            carIdInfo.IDNum = idNum;
            carIdInfo.Owner = owner;
        }

        public void getCarIdInfo()
        {
            Console.WriteLine("This car has the ID of {0} and is owned by {1}", carIdInfo.IDNum, carIdInfo.Owner);
        }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void showDetails()
        {
            Console.WriteLine("HP: " + this.HP + " color: " + this.Color);
        }

        // By making a method virtual, allows me to override it
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired.");
        }
    }
}

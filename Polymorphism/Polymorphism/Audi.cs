using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Audi : Car
    {
        private string brand = "Audi";

        private string model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color) // Like calling super() in Java/Javascript
        {
            this.model = model;
        }

        public new void showDetails()
        {
            Console.WriteLine("Brand: " + this.brand + " model: " + this.model);
        }

        public override void Repair()
        {
            Console.WriteLine("The Audi " + this.model + " has been repaired.");
        }
    }
}

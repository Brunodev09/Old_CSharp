using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class BMW : Car
    {
        private string brand = "BMW";

        private string model { get; set; }

        public BMW(int hp, string color, string model) : base(hp, color) // Like calling super()
        {
            this.model = model;
        }

        public new void showDetails()
        {
            Console.WriteLine("HP: " + this.HP + "Brand: " + this.brand + " model: " + this.model);
        }

        // sealed keyword prevents this method from being overriden from inheriting classes
        // can only seal override methods
        public sealed override void Repair()
        {
            Console.WriteLine("The BMW " + this.model + " has been repaired.");
        }
    }
}

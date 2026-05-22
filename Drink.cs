using System;

namespace VendingMachineApp
{
    //asså det är typ samma skit som alla andra klasser
    public class Drink : Product
    {
        public string Volume { get; set; }

        public Drink(string name, decimal price, string volume)
            : base(name, price)
        {
            Volume = volume;
        }

        //här dricker man det om det inte var så tydligt
        public override void Use()
        {
            Console.WriteLine($"Du dricker {Name} ({Volume})");
        }

        public override void Examine()
        {
            Console.WriteLine($"{Name} ({Volume}) - {Price} kr");
        }
    }
}
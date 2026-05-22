using System;

namespace VendingMachineApp
{
    //leksaker är kul
    public class Toy : Product
    {
        //konstruktor som tar in namn och pris
        public Toy(string name, decimal price)
            : base(name, price)
        {
        }

        public override void Use()
        {
            Console.WriteLine($"Du leker med {Name}");//wooohooo
        }
        //gissa vad den här gör(den skriver ut namnet och priset på leksaken)
        public override void Examine()
        {
            Console.WriteLine($"{Name} - {Price} kr");
        }
    }
}
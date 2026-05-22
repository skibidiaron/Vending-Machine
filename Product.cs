using System;

namespace VendingMachineApp
{
    //den här klassen visar produkterna och hur mycket de kostar
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        protected Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        //här skriver den ut namnet och priset på produkten
        public virtual void Examine()
        {
            Console.WriteLine($"{Name} kostar {Price} kr");
        }

        public abstract void Use();
    }
}
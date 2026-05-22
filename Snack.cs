using System;

namespace VendingMachineApp
{
    public class Snack : Product
    {
        public int Calories { get; set; }//så man inte blir tjock

        //konstruktor som tar in namn och pris och kalorier
        public Snack(string name, decimal price, int calories)
            : base(name, price)
        {
            Calories = calories;
        }

        //här står det hur många kalorier man äter så man inte blir tjock
        public override void Use()
        {
            Console.WriteLine($"Du äter {Name} ({Calories} kcal)");
        }

        public override void Examine()
        {
            Console.WriteLine($"{Name} ({Calories} kcal) - {Price} kr");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachineApp
{
    public class VendingMachine //det är här magin sker
    {
        public List<Product> Products { get; } = new List<Product>();
        public decimal MoneyPool { get; private set; } = 0m;

        private readonly int[] _validCoins = { 5, 10, 20, 50 };

        //lägger till dina pengar
        public void InsertMoney(int amount)
        {
            //kontrollerar om någon lyckades skriva fel
            if (_validCoins.Contains(amount))
            {
                MoneyPool += amount;
                Console.WriteLine($"Saldo: {MoneyPool} kr");
            }
            else
            {
                Console.WriteLine("Ogiltig peng ditt dumma kromosom fel det står tydligt att accepterade mynt är: 5,10,20,50");
            }
        }

        //visar produkterna
        public void ShowProducts()
        {
            //kontrollerar om det finns några produkter
            if (Products.Count == 0)
            {
                Console.WriteLine("Inga produkter tillgängliga.");
                return;
            }

            for (int i = 0; i < Products.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                Products[i].Examine();
            }
        }

        //köper produkten
        public void Purchase(int productNumber)
        {
            if (productNumber < 1 || productNumber > Products.Count)
            {
                Console.WriteLine("Fel val!");
                return;
            }

            Product product = Products[productNumber - 1];

            if (MoneyPool >= product.Price)
            {
                MoneyPool -= product.Price;
                Console.WriteLine($"Du köpte {product.Name} för {product.Price} kr");
                product.Use();
                Products.RemoveAt(productNumber - 1);
                Console.WriteLine($"Kvarvarande saldo: {MoneyPool} kr");
            }
            else
            {
                Console.WriteLine($"Inte tillräckligt med pengar! Du behöver {(product.Price - MoneyPool):0.##} kr till.");
            }
        }

        //du få
        public void EndTransaction()
        {
            if (MoneyPool > 0)
            {
                Console.WriteLine($"Du får tillbaka {MoneyPool} kr");
                MoneyPool = 0m;
            }
            else
            {
                Console.WriteLine("Ingen saldo att ta ut.");
            }
        }
    }
}
using System;

namespace VendingMachineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var vm = new VendingMachine();

            vm.Products.Add(new Drink("Cola", 25m, "67cl"));
            vm.Products.Add(new Drink("Fanta", 25m, "67cl"));
            vm.Products.Add(new Snack("Chips", 20m, 250));
            vm.Products.Add(new Snack("Choklad", 15m, 200));
            vm.Products.Add(new Toy("Toy Car", 50m));
            vm.Products.Add(new Toy("Trollface", 30m));
            vm.Products.Add(new Snack("Nötter", 20m, 300));

            //Main loop som visar menyn och hanterar användarens val
            while (true)
            {
                Console.WriteLine("\n--- Varuautomat ---");
                Console.WriteLine("1. Stoppa in pengar");
                Console.WriteLine("2. Visa produkter");
                Console.WriteLine("3. Köp produkt");
                Console.WriteLine("4. Avsluta");
                Console.Write("Val: ");

                string choice = Console.ReadLine()?.Trim();

                //meny valen
                switch (choice)
                {
                    case "1":
                        Console.Write("Ange ett av beloppen och inget annat (5,10,20,50): ");
                        if (int.TryParse(Console.ReadLine(), out int money))
                        {
                            vm.InsertMoney(money);
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt belopp dumhuvud");
                        }
                        break;

                    case "2":
                        vm.ShowProducts();
                        break;

                    case "3":
                        Console.Write("Välj produktnummer: ");
                        if (int.TryParse(Console.ReadLine(), out int prod))
                        {
                            vm.Purchase(prod);
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt nummer dumhuvud");
                        }
                        break;

                    case "4":
                        vm.EndTransaction();
                        return;

                    default:
                        Console.WriteLine("Fel val");
                        break;
                }
            }
        }
    }
}
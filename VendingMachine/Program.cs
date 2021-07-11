using System;
using VendingMachineProject.VendingItems;

namespace VendingMachineProject
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new ();

            bool insertMoreMoney = true;
            do
            {
                Console.WriteLine($"Put money in the machine.\nAccepted denominations: {vendingMachine.ValidDenominations}");
                Console.WriteLine();

                Console.WriteLine("Press 'd' when you are done.");

                Console.WriteLine();
                Console.WriteLine($"Money in the vending machine: {vendingMachine.MoneyPool}kr");

                Console.WriteLine("---- Insert money ----");
                Console.Write("Insert: ");

                string userMoneyString = Console.ReadLine();

                if (userMoneyString.Equals("d"))
                {
                    insertMoreMoney = false;
                }
                else
                {
                    int userMoneyInt = int.Parse(userMoneyString);
                    vendingMachine.InsertMoney(userMoneyInt);

                    Console.WriteLine();
                }
            }
            while (insertMoreMoney);

            Console.WriteLine();

            VendingItem redApple = new Apple("Red apple", 4);
            VendingItem greenApple = new Apple("Green apple", 5);
            VendingItem colaZero = new Cola("Cola zero", 7);
            VendingItem colaSugar = new Cola("Cola sugar", 13);
            VendingItem onionChips = new Chips("Onion chips", 15);
            VendingItem potatoChips = new Chips("Potato chips", 12);

            vendingMachine.AddItem(redApple);
            vendingMachine.AddItem(greenApple);
            vendingMachine.AddItem(colaZero);
            vendingMachine.AddItem(colaSugar);
            vendingMachine.AddItem(onionChips);
            vendingMachine.AddItem(potatoChips);

            Console.WriteLine("Your item choices are:");
            Console.Write(vendingMachine.ShowAll());

            Console.WriteLine();

            bool buyMoreItems = true;
            do
            {
                Console.WriteLine();
                Console.WriteLine($"Money in the vending machine: {vendingMachine.MoneyPool}kr");

                Console.Write("Write which item to choose. Enter -1 when done: ");
                int userChoiceByItemNumber = int.Parse(Console.ReadLine());

                switch (userChoiceByItemNumber)
                {
                    case 1:
                        Console.Write(vendingMachine.Purchase(redApple));
                        break;
                    case 2:
                        Console.WriteLine(vendingMachine.Purchase(greenApple));
                        break;
                    case 3:
                        Console.WriteLine(vendingMachine.Purchase(colaZero));
                        break;
                    case 4:
                        Console.WriteLine("Cola sugar bought!");
                        Console.WriteLine();
                        Console.WriteLine(vendingMachine.Purchase(colaSugar));
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine(vendingMachine.Purchase(onionChips));
                        break;
                    case 6:
                        Console.WriteLine(vendingMachine.Purchase(potatoChips));
                        break;
                    case -1:
                        buyMoreItems = false;
                        break;
                    default:
                        Console.WriteLine("There are no items with that number.");
                        break;
                }
            }
            while (buyMoreItems);

            Console.WriteLine("Returning change.");
            Console.WriteLine();

            Console.WriteLine(vendingMachine.EndTransaction());
        }
    }
}

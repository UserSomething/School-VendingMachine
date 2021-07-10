using System;
using VendingMachineProject.VendingItems;

namespace VendingMachineProject
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vending = new VendingMachine();
            vending.AddItem(new Apple("Strange apple", 4));
            vending.AddItem(new Chips("Potato chips", 15));
            vending.AddItem(new Cola("Regular cola", 7));

            vending.ShowAll();
        }
    }
}

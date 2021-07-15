using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineProject.VendingItems;

namespace VendingMachineProject
{
    public class VendingMachine : IVending
    {
        private VendingItem[] vendingItems = Array.Empty<VendingItem>();
        private int nextVendingItemsIndex = 0;

        private readonly int[] validMoneyArray = { 1, 5, 10, 20, 50, 100, 500, 1000 };

        public string ValidDenominations { get; } = "1, 5, 10, 20, 50, 100, 500, 1000";

        public int MoneyPool { get; set; }

        public void AddItem(VendingItem vendingItem)
        {
            Array.Resize(ref this.vendingItems, this.vendingItems.Length + 1);

            this.vendingItems[this.nextVendingItemsIndex] = vendingItem;
            this.nextVendingItemsIndex++;
        }

        public string Purchase(VendingItem item)
        {
            if ((this.MoneyPool - item.Price) < 0)
            {
                Console.WriteLine();
                return "Not enough money for this product.";
            }

            this.MoneyPool -= item.Price;

            return item.Use();
        }

        public string ShowAll()
        {
            int itemNumber = 1;
            StringBuilder allItemsInfoAndPrice = new ();

            foreach (VendingItem v in this.vendingItems)
            {
                allItemsInfoAndPrice.Append($"{itemNumber}. {v.Examine()}\n");
                itemNumber++;
            }

            return allItemsInfoAndPrice.ToString();
        }

        public void InsertMoney(int insertedMoney)
        {
            bool isValidMoney = false;

            foreach (int validMoney in this.validMoneyArray)
            {
                if (insertedMoney < validMoney)
                {
                    break;
                }

                if (insertedMoney == validMoney)
                {
                    this.MoneyPool += insertedMoney;
                    isValidMoney = true;
                    break;
                }
                else
                {
                    continue;
                }
            }

            if (isValidMoney)
            {
                Console.WriteLine($"{insertedMoney}kr inserted.");
            }
            else
            {
                Console.WriteLine($"Can't accept {insertedMoney}kr, giving it back.");
            }
        }

        public string EndTransaction()
        {
            Dictionary<int, int> moneyLookup = new ()
            {
                { 1000, 1000 },
                { 500, 500 },
                { 100, 100 },
                { 50, 50 },
                { 20, 20 },
                { 10, 10 },
                { 5, 5 },
                { 1, 1 },
            };

            int moneyToReturn = 0;

            foreach (var pair in moneyLookup)
            {
                while (this.MoneyPool >= pair.Key)
                {
                    this.MoneyPool -= pair.Value;
                    moneyToReturn += pair.Value;
                }
            }

            return $"{moneyToReturn}kr returned.";
        }
    }
}

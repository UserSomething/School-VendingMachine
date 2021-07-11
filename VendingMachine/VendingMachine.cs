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
            int moneyToReturn = 0;

            while (this.MoneyPool != 0)
            {
                if (this.MoneyPool >= 1000)
                {
                    this.MoneyPool -= 1000;
                    moneyToReturn += 1000;
                }

                if (this.MoneyPool >= 500)
                {
                    this.MoneyPool -= 500;
                    moneyToReturn += 500;
                }

                if (this.MoneyPool >= 100)
                {
                    this.MoneyPool -= 100;
                    moneyToReturn += 100;
                }

                if (this.MoneyPool >= 50)
                {
                    this.MoneyPool -= 50;
                    moneyToReturn += 50;
                }

                if (this.MoneyPool >= 20)
                {
                    this.MoneyPool -= 20;
                    moneyToReturn += 20;
                }

                if (this.MoneyPool >= 10)
                {
                    this.MoneyPool -= 10;
                    moneyToReturn += 10;
                }

                if (this.MoneyPool >= 5)
                {
                    this.MoneyPool -= 5;
                    moneyToReturn += 5;
                }

                if (this.MoneyPool >= 1)
                {
                    this.MoneyPool -= 1;
                    moneyToReturn += 1;
                }
            }

            return $"{moneyToReturn}kr returned.";
        }
    }
}

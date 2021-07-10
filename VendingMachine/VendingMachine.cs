using System;
using System.Text;
using VendingMachineProject.VendingItems;

namespace VendingMachineProject
{
    public class VendingMachine : IVending
    {
        private VendingItem[] vendingItems = Array.Empty<VendingItem>();
        private int nextVendingItemsIndex = 0;

        private readonly int[] validMoneyArray = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        private int[] nonValidMoneyArray = Array.Empty<int>();

        public int MoneyPool { get; set; }

        public void AddItem(VendingItem item)
        {
            Array.Resize(ref this.vendingItems, this.vendingItems.Length + 1);

            this.vendingItems[this.nextVendingItemsIndex] = item;
            this.nextVendingItemsIndex++;
        }

        public void Purchase()
        {
            throw new NotImplementedException();
        }

        public string ShowAll()
        {
            StringBuilder allItemsInfoAndPrice = new ();

            foreach (VendingItem v in this.vendingItems)
            {
                allItemsInfoAndPrice.Append($"{v.Examine()}\n");
            }

            return allItemsInfoAndPrice.ToString();
        }

        public string InsertMoney(params int[] insertedMoneyArray)
        {
            throw new NotImplementedException();
        }

        public int EndTransaction()
        {
            throw new NotImplementedException();
        }
    }
}

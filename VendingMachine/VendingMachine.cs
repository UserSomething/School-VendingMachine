using System;

namespace VendingMachine
{
    public class VendingMachine : IVending
    {
        readonly int[] validMoney = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        decimal moneyPool = 0;

        public void Purchase()
        {
            throw new NotImplementedException();
        }

        public void ShowAll()
        {
            throw new NotImplementedException();
        }

        public void InsertMoney(int money)
        {
            throw new NotImplementedException();
        }

        public int EndTransaction()
        {
            throw new NotImplementedException();
        }
    }
}

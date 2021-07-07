namespace VendingMachine
{
    public interface IVending
    {
        void Purchase();
        void ShowAll();
        void InsertMoney(int money);
        int EndTransaction();
    }
}
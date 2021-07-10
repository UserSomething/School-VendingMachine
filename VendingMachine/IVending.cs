using VendingMachineProject.VendingItems;

namespace VendingMachineProject
{
    public interface IVending
    {
        void Purchase();
        string ShowAll();
        string InsertMoney(params int[] moneyArray);
        int EndTransaction();
    }
}
using VendingMachineProject.VendingItems;

namespace VendingMachineProject
{
    public interface IVending
    {
        string Purchase(VendingItem item);

        string ShowAll();

        void InsertMoney(int insertedMoney);

        string EndTransaction();
    }
}
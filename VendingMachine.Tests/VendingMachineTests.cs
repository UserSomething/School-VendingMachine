using VendingMachineProject.VendingItems;
using Xunit;

namespace VendingMachineProject.Tests
{
    public class VendingMachineTests
    {
        [Fact]
        public void When_ShowAllCalled_Expect_RedAppleAndPotatoChipsAndColaInfoAndPrice()
        {
            // Arrange
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.AddItem(new Apple("Red apple", 5));
            vendingMachine.AddItem(new Chips("Potato chips", 11));
            vendingMachine.AddItem(new Cola("Cola", 7));

            string expected = "1. Red apple - 5kr.\n2. Potato chips - 11kr.\n3. Cola - 7kr.\n";
            // Act
            string actual = vendingMachine.ShowAll();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_ShowAllCalled_Expect_AllItemsInfoAndPrice()
        {
            // Arrange
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.AddItem(new Apple("Green apple", 19));
            vendingMachine.AddItem(new Chips("Salted chips", 20));
            vendingMachine.AddItem(new Cola("Cola zero", 12));

            string expected = "1. Green apple - 19kr.\n2. Salted chips - 20kr.\n3. Cola zero - 12kr.\n";
            // Act
            string actual = vendingMachine.ShowAll();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_ApplePurchased_Expect_AppleUsageString()
        {
            VendingMachine vendingMachine = new();
            vendingMachine.MoneyPool = 100;
            string expected = "Eating the apple: Grab and bite.";

            VendingItem apple = new Apple("Red apple", 6);
            string actual = vendingMachine.Purchase(apple);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_ChipsPurchased_Expect_ChipsUsageString()
        {
            VendingMachine vendingMachine = new();
            vendingMachine.MoneyPool = 100;
            string expected = "Opening the chips: Open the package by the sides.";

            VendingItem chips = new Chips("Chips", 20);
            string actual = vendingMachine.Purchase(chips);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_ColaPurchased_Expect_ColaUsageString()
        {
            VendingMachine vendingMachine = new();
            vendingMachine.MoneyPool = 100;
            string expected = "Opening the cola: Use a finger to lift the small metal part of the can so it opens.";

            VendingItem cola = new Cola("Cola zero", 14);
            string actual = vendingMachine.Purchase(cola);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(5, 5)]
        [InlineData(10, 10)]
        public void When_RightMoneyInserted_Expect_RightAmountInMoneyPool(int rightMoney, int expected)
        {
            VendingMachine vendingMachine = new ();

            vendingMachine.InsertMoney(rightMoney);
            int actual = vendingMachine.MoneyPool;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, "1kr returned.")]
        [InlineData(5, "5kr returned.")]
        [InlineData(6, "6kr returned.")]
        [InlineData(1253, "1253kr returned.")]
        public void When_TransactionEndedAnyKrAmountInMoneyPool_Expect_AllKrReturned(int moneyPoolAmount, string expected)
        {
            VendingMachine vendingMachine = new();

            vendingMachine.MoneyPool = moneyPoolAmount;
            string actual = vendingMachine.EndTransaction();

            Assert.Equal(expected, actual);
        }
    }
}

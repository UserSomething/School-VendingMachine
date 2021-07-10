using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            string expected = "Red apple - 5kr.\nPotato chips - 11kr.\nCola - 7kr.\n";
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

            string expected = "Green apple - 19kr.\nSalted chips - 20kr.\nCola zero - 12kr.\n";
            // Act
            string actual = vendingMachine.ShowAll();
            // Assert
            Assert.Equal(expected, actual);
        }

        //[Fact]
        //public void When_1krInserted_Expect_1krInMoneyPool()
        //{
        //    // Arrange
        //    VendingMachine vendingMachine = new VendingMachine();
        //    int expected = 1;
        //    // Act
        //    vendingMachine.InsertMoney(1);
        //    int actual = vendingMachine.MoneyPool;
        //    // Assert
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void When_2krInserted_Expect_Give2krBackToCustomer()
        //{
        //    // Arrange
        //    VendingMachine vendingMachine = new VendingMachine();
        //    string expected = "Can't accept 2kr, returning the money.";
        //    // Act
        //    string actual = vendingMachine.InsertMoney(2);
        //    // Assert
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void When_5krInserted_Expect_5krInMoneyPool()
        //{
        //    // Arrange
        //    VendingMachine vendingMachine = new VendingMachine();
        //    int expected = 5;
        //    // Act
        //    vendingMachine.InsertMoney(5);
        //    int actual = vendingMachine.MoneyPool;
        //    // Assert
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void When_7krInserted_Expect_Give7krBackToCustomer()
        //{
        //    // Arrange
        //    VendingMachine vendingMachine = new VendingMachine();
        //    string expected = "Can't accept 7kr, returning the money.";
        //    // Act
        //    string actual = vendingMachine.InsertMoney(7);
        //    // Assert
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void When_10krInserted_Expect_10krInMoneyPool()
        //{
        //    // Arrange
        //    VendingMachine vendingMachine = new VendingMachine();
        //    int expected = 10;
        //    // Act
        //    vendingMachine.InsertMoney(10);
        //    int actual = vendingMachine.MoneyPool;
        //    // Assert
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void When_12krInserted_Expect_Give12krBackToCustomer()
        //{
        //    // Arrange
        //    VendingMachine vendingMachine = new VendingMachine();
        //    string expected = "Can't accept 12kr, returning the money.";
        //    // Act
        //    string actual = vendingMachine.InsertMoney(12);
        //    // Assert
        //    Assert.Equal(expected, actual);
        //}
    }
}

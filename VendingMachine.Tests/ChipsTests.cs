using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineProject.VendingItems;
using Xunit;

namespace VendingMachineProject.Tests
{
    public class ChipsTests
    {
        [Fact]
        public void When_ChipsExamined_Expect_ChipsInfo()
        {
            // Arrange
            string expected = "Super chips - 150kr.";
            Chips chips = new Chips("Super chips", 150);
            // Act
            string actual = chips.Examine();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_ChipsUsed_Expect_ChipsUsageInfo()
        {
            // Arrange
            string expected = "Open the package by the sides.";
            Chips chips = new Chips("Potato chips", 15);
            // Act
            string actual = chips.Use();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

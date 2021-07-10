using System;
using Xunit;
using VendingMachineProject.VendingItems;

namespace VendingMachineProject.Tests
{
    public class VendingItemsTests
    {
        [Fact]
        public void When_ColaExamined_Expect_ColaInfo()
        {
            // Arrange
            string expected = "Regular cola - 5kr.";
            VendingItem cola = new Cola("Regular cola", 5);
            // Act
            string actual = cola.Examine();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AppleExamined_Expect_AppleInfo()
        {
            // Arrange
            string expected = "Green apple - 10kr.";
            VendingItem apple = new Apple("Green apple", 10);
            // Act
            string actual = apple.Examine();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_ChipsExamined_Expect_ChipsInfo()
        {
            // Arrange
            string expected = "Potato chips - 15kr.";
            VendingItem chips = new Chips("Potato chips", 15);
            // Act
            string actual = chips.Examine();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_ColaUsed_Expect_ColaUsageInfo()
        {
            // Arrange
            string expected = "Use a finger to lift the small metal part of the can so it opens.";
            VendingItem cola = new Cola("Regular cola", 5);
            // Act
            string actual = cola.Use();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AppleUsed_Expect_AppleUsageInfo()
        {
            // Arrange
            string expected = "Grab and bite.";
            VendingItem apple = new Apple("Green apple", 10);
            // Act
            string actual = apple.Use();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_ChipsUsed_Expect_ChipsUsageInfo()
        {
            // Arrange
            string expected = "Open the package by the sides.";
            VendingItem chips = new Chips("Potato chips", 15);
            // Act
            string actual = chips.Use();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

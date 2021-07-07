using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineProject.VendingItems;
using Xunit;

namespace VendingMachineProject.Tests
{
    public class AppleTests
    {
        [Fact]
        public void When_AppleExamined_Expect_AppleInfo()
        {
            // Arrange
            string expected = "Info: More green apple.\nPrice: 1000kr.";
            Apple apple = new Apple("More green apple", 1000);
            // Act
            string actual = apple.Examine();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AppleUsed_Expect_AppleUsageInfo()
        {
            // Arrange
            string expected = "Grab and bite.";
            Apple apple = new Apple("More green apple", 1000);
            // Act
            string actual = apple.Use();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

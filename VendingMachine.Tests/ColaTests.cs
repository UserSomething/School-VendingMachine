using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineProject.VendingItems;
using Xunit;

namespace VendingMachineProject.Tests
{
    public class ColaTests
    {
        [Fact]
        public void When_ColaExamined_Expect_ColaInfo()
        {
            // Arrange
            string expected = "Supreme cola - 50kr.";
            Cola cola = new Cola("Supreme cola", 50);
            // Act
            string actual = cola.Examine();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_ColaUsed_Expect_ColaUsageInfo()
        {
            // Arrange
            string expected = "Use a finger to lift the small metal part of the can so it opens.";
            Cola cola = new Cola("Supreme cola", 50);
            // Act
            string actual = cola.Use();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

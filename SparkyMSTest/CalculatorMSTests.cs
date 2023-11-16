using Sparky;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky;

[TestClass]
public class CalculatorMSTests
{
    [TestMethod]
    public void AddNumbers_should_return_sum()
    {
        // Arrange
        Calculator calculator = new();
        int a = 1;
        int b = 2;
        int expected = 3;
        // Act
        int actual = calculator.AddNumbers(a, b);
        // Assert
        Assert.AreEqual(expected, actual);
    }
}

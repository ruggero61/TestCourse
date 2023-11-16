using Sparky;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky;

[TestFixture]
public class CalculatorNUnitTests
{
    [Test]
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

    [TestCase(8,9)]
    public void SubtractNumbers_should_return_difference(int a, int b)
    {
        // Arrange
        Calculator calculator = new();
        int expected = -1;
        // Act
        int actual = calculator.SubtractNumbers(a, b);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void IsOddNumber_should_return_true_for_odd_number()
    {
        // Arrange
        Calculator calculator = new();
        int a = 1;
        bool expected = true;
        // Act
        bool actual = calculator.IsOddNumber(a);
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestCase(2, ExpectedResult = true)]
    [TestCase(26, ExpectedResult = true)]
    [TestCase(-222, ExpectedResult = true)]
    [TestCase(-2, ExpectedResult = true)]
    [TestCase(204, ExpectedResult = true)]
    [TestCase(300, ExpectedResult = true)]
    [TestCase(2210, ExpectedResult = true)]
    [TestCase(30, ExpectedResult = true)]
    [TestCase(20, ExpectedResult = true)]
    [TestCase(21, ExpectedResult = false)]
    [TestCase(23, ExpectedResult = false)]
    [TestCase(25, ExpectedResult = false)]
    [TestCase(8, ExpectedResult = true)]
    [TestCase(6, ExpectedResult = true)]
    public bool IsEvenNumber_should_return_true_for_even_number(int a)
    {
        Calculator calculator = new();
        return calculator.IsEvenNumber(a);
    }
    [Test]
    public void SquareRootNumber_should_return_sqrt_for_a_number() 
    {
        //Arrange
        Calculator calculator = new();

        //Act
        int i = 4;
        int expected = 2;
        int actual = calculator.SquareRootNumber(i);

        //Assert
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void SquareNumber_should_return_square_of_number() 
    {
        // Arrange 
        Calculator calculator = new();

        // Act
        int i = 5;
        int expected = 25;
        int actual = calculator.SquareNumber(i);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CubeNumber_should_return_cube_of_number()
    {
        // Arrange
        Calculator calculator = new();

        // Act
        int i = 5;
        int expected = 125;
        int actual = calculator.CubeNumber(i);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}

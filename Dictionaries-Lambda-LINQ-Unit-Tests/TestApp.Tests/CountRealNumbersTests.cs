using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] arr = new int[] {};
   

        // Act
        string actual = CountRealNumbers.Count(arr);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] arr = new int[] {3};
        string expected = "3 -> 1";


        // Act
        string actual = CountRealNumbers.Count(arr);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] arr = new int[] { 3, 5, 3, 7 };
        string expected = string.Join(Environment.NewLine, new[]
        {
            "3 -> 2",
            "5 -> 1",
            "7 -> 1"
        });


        // Act
        string actual = CountRealNumbers.Count(arr);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] arr = new int[] { -3, -7, -7, -3, -5 };
        string expected = string.Join(Environment.NewLine, new[]
        {
            "-7 -> 2",
            "-5 -> 1",
            "-3 -> 2"
        });


        // Act
        string actual = CountRealNumbers.Count(arr);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] arr = new int[] { 0, 2, 2 };
        string expected = string.Join(Environment.NewLine, new[]
        {
            "0 -> 1",
            "2 -> 2"
        });


        // Act
        string actual = CountRealNumbers.Count(arr);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace TestApp.Tests;

public class GroupingTests
{
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> list = new List<int>();

        // Act
        string actual = Grouping.GroupNumbers(list);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int>() { 2, 4, 6, 3, 5, 7};
        string expected = string.Join(Environment.NewLine, new[]
        {
            "Even numbers: 2, 4, 6",
            "Odd numbers: 3, 5, 7"
        });

        // Act
        string actual = Grouping.GroupNumbers(list);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int>() { 2, 4, 6 };
        string expected = "Even numbers: 2, 4, 6";

        // Act
        string actual = Grouping.GroupNumbers(list);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int>() { 5, 7, 13 };
        string expected = "Odd numbers: 5, 7, 13";

        // Act
        string actual = Grouping.GroupNumbers(list);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int>() { -2, -4, -6, -11, -3, -9 };
        string expected = string.Join(Environment.NewLine, new[]
        {
            "Even numbers: -2, -4, -6",
            "Odd numbers: -11, -3, -9"
        });

        // Act
        string actual = Grouping.GroupNumbers(list);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

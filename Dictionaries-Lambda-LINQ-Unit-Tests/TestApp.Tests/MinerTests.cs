using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] arr = new string[] { };

        string actual = Miner.Mine(arr);

        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] arr = new string[] { "Gold 100", "Silver 200", "GOLD 150", "SILVER 50"};
        string expected = string.Join(Environment.NewLine, new []{
            "gold -> 250",
            "silver -> 250"
        });

        // Act
        string result = Miner.Mine(arr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        string[] arr = new string[] {
    "gold 100",
    "silver 200",
    "gold 150",
    "silver 150",
    "iron 330"
};

        string expected = string.Join(Environment.NewLine, new[]{
            "gold -> 250",
            "silver -> 350",
            "iron -> 330"
        });

        // Act
        string result = Miner.Mine(arr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

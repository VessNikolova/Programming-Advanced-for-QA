using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("university", 2, "uNiVeRsItYuNiVeRsItY")]
    [TestCase("Hi", 3, "hIhIhI")]
    [TestCase("DeVeLoPeR", 1, "dEvElOpEr")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        //Arrange
        string input = "";
        int repetitionFactor = 6;

        // Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        //Arrange
        string input = "College";
        int repetitionFactor = -5;

        // Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        //Arrange
        string input = "College";
        int repetitionFactor = 0;

        // Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }
}

using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string input = "31-Dec-2022";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        string actual = MatchDates.Match(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = "Invalid date format";
        string expected = string.Empty;

        // Act
        string actual = MatchDates.Match(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        string input = "31-Dec-2022, 27 feb 1989, 19-Feb.1990, 23.Jul 1999";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        string actual = MatchDates.Match(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected)); 
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Act
        string actual = MatchDates.Match(string.Empty);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Assert
        Assert.Throws<ArgumentException>(() => MatchDates.Match(null));
    }
}

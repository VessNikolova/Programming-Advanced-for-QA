﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchPhoneNumbersTests
{
    [Test]
    public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers()
    {
        // Arrange
        string phoneNumbers = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

        // Act
        string actual = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(actual, Is.EqualTo(phoneNumbers));
    }

    [Test]
    public void Test_Match_NoValidPhoneNumbers_ReturnsEmptyString()
    {
        // Arrange
        string phoneNumbers = "+359-2-124-5678e, +359 2 986 54324, +359 2-555-5555";

        // Act
        string actual = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        // Act
        string actual = MatchPhoneNumbers.Match(string.Empty);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Match_MixedValidAndInvalidNumbers_ReturnsOnlyValidNumbers()
    {
        // Arrange
        string phoneNumbers = "+359-2-124-5678e, +359 2 111 2345, +359 2 986 54324, +359-2-234-5434, +359 2-555-5555";
        string expected = "+359 2 111 2345, +359-2-234-5434";

        // Act
        string actual = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

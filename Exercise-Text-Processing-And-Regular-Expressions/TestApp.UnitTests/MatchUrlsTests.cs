using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";

        // Act
        List<string> list = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(list, Is.EqualTo(new List<string>()));
    }
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "It's a core component of many operating systems, providing a foundation for interacting with hardware and running software.";

        // Act
        List<string> list = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(list, Is.EqualTo(new List<string>()));
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "For more information, visit the official website at https://www.google.com";
        List<string> expectedList = new List<string>() { "https://www.google.com" };

        // Act
        List<string> list = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(list, Is.EqualTo(expectedList));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "If you're searching for information, you can start with https://www.google.com " +
            "For developer resources, visit https://developer.mozilla.org To stay updated on tech news, check out https://www.techcrunch.com " +
            "If you're working with APIs, https://api.github.com provides great documentation.";
        List<string> expectedList = new List<string>() { "https://www.google.com", "https://developer.mozilla.org", "https://www.techcrunch.com", "https://api.github.com" };

        // Act
        List<string> list = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(list, Is.EqualTo(expectedList));
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "Here are some URLs: \"https://www.google.com\", \"http://example.org\" and \"https://api.test.com/data\".";
        List<string> expected = new List<string>
    {
        "https://www.google.com",
        "http://example.org",
        "https://api.test.com"
    };

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{

    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new string[] { "Bear", "Softuni" };
        string text = "Linux and Windows are popular operating systems. Linux offers flexibility, " +
            "while Windows is widely used. Developers often test their applications on both Linux and Windows.";

        string expected = "Linux and Windows are popular operating systems. Linux offers flexibility, " +
            "while Windows is widely used. Developers often test their applications on both Linux and Windows.";

        // Act
        string actual = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = new string[] { "Linux", "Windows" };
        string text = "Linux and Windows are popular operating systems. Linux offers flexibility, " +
            "while Windows is widely used. Developers often test their applications on both Linux and Windows.";

        string expected = "***** and ******* are popular operating systems. ***** offers flexibility, " +
            "while ******* is widely used. Developers often test their applications on both ***** and *******.";

        // Act
        string actual = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = Array.Empty<string>();
        string text = "Linux and Windows are popular operating systems. Linux offers flexibility, " +
            "while Windows is widely used. Developers often test their applications on both Linux and Windows.";

        string expected = "Linux and Windows are popular operating systems. Linux offers flexibility, " +
            "while Windows is widely used. Developers often test their applications on both Linux and Windows.";

        // Act
        string actual = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = new string[] { "Linux Programs", "Windows Programs" };
        string text = "Linux and Windows are popular operating systems. Linux Programs offers flexibility, " +
            "while Windows Programs is widely used. Developers often test their applications on both Linux and Windows.";

        string expected = "Linux and Windows are popular operating systems. ************** offers flexibility, " +
            "while **************** is widely used. Developers often test their applications on both Linux and Windows.";

        // Act
        string actual = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

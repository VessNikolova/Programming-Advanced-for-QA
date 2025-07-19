using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] arr = new string[] { };

        string actual = OddOccurrences.FindOdd(arr);

        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        string[] arr = new string[] { "cat", "dog", "tree", "cat", "dog", "tree"};

        string actual = OddOccurrences.FindOdd(arr);

        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        string[] arr = new string[] { "cat", "dog", "tree", "dog", "tree" };
        string expected = "cat";

        string actual = OddOccurrences.FindOdd(arr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        string[] arr = new string[] { "cat", "dog", "tree" };
        string expected = "cat dog tree";

        string actual = OddOccurrences.FindOdd(arr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        string[] arr = new string[] { "cat", "dog", "tree", "Dog", "Tree", "Cat", "CAT", "TREE" };
        string expected = "cat tree";

        string actual = OddOccurrences.FindOdd(arr);

        Assert.That(actual, Is.EqualTo(expected));
    }
}

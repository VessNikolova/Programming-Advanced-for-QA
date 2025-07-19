using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] arr = new string[] { };

        string actual = Plants.GetFastestGrowing(arr);

        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        string[] arr = new string[] { "tulip" };
        string expectec = string.Join(Environment.NewLine, new[]
        {
            "Plants with 5 letters:",
        "tulip"
        });

        string actual = Plants.GetFastestGrowing(arr);

        Assert.That(actual, Is.EqualTo(expectec));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        string[] arr = new string[] { "fern", "lily", "daisy", "mango", "oak", "maple" };
        string expectec = string.Join(Environment.NewLine, new[]
        {
            "Plants with 3 letters:",
        "oak",
        "Plants with 4 letters:",
        "fern",
        "lily",
        "Plants with 5 letters:",
        "daisy",
        "mango",
        "maple"
        });

        string actual = Plants.GetFastestGrowing(arr);

        Assert.That(actual, Is.EqualTo(expectec));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        string[] arr = new string[] { "Fern", "fern", "lily", "daisy", "DAISY", "mango", "oak", "maple" };
        string expectec = string.Join(Environment.NewLine, new[]
        {
            "Plants with 3 letters:",
        "oak",
        "Plants with 4 letters:",
        "Fern",
        "fern",
        "lily",
        "Plants with 5 letters:",
        "daisy",
        "DAISY",
        "mango",
        "maple"
        });

        string actual = Plants.GetFastestGrowing(arr);

        Assert.That(actual, Is.EqualTo(expectec));
    }
}

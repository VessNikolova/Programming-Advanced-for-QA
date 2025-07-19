using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] arr = new string[] { };

        string actual = Orders.Order(arr);

        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    // TODO: finish test
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        string[] arr = new string[] { "Coke 1.5 3", "Cookie 2.2 2"};
        string expected = string.Join(Environment.NewLine, new[]
        {
            "Coke -> 4.50",
            "Cookie -> 4.40"
        });

        string actual = Orders.Order(arr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        string[] arr = new string[] { "Coke 1 3", "Cookie 2 2", "Chocolate 3 4"};
        string expected = string.Join(Environment.NewLine, new[]
        {
            "Coke -> 3.00",
            "Cookie -> 4.00",
            "Chocolate -> 12.00"
        });

        string actual = Orders.Order(arr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        string[] arr = new string[] { "Coke 1.1 3.3", "Cookie 2.2 2.2", "Chocolate 3.1 4.4" };
        string expected = string.Join(Environment.NewLine, new[]
        {
            "Coke -> 3.63",
            "Cookie -> 4.84",
            "Chocolate -> 13.64"
        });

        string actual = Orders.Order(arr);

        Assert.That(actual, Is.EqualTo(expected));
    }
}

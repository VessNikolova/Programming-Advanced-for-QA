using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("vik89@abv.bg")]
    [TestCase("user123+promo@sub.domain.co")]
    [TestCase("my.email-2025@service-provider.org")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("userlocalhost")]
    [TestCase("name@domain.toolongtl.dddt@")]
    [TestCase("email@@h-example.com.com")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}

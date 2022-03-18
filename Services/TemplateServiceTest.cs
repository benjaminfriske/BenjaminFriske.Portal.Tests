using Microsoft.VisualStudio.TestTools.UnitTesting;
using BenjaminFriske.Portal.Services;

namespace BenjaminFriske.Portal.Tests.Services;


/// <summary>
/// https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
/// Naming your tests
/// The name of the method being tested.
/// The scenario under which it's being tested.
/// The expected behavior when the scenario is invoked.
/// </summary>
    
[TestClass]
public class TemplateServiceTest
{
    [TestInitialize]
    public void Setup()
    {
    // Runs before each test. (Optional)
    }

    [TestMethod]
    public void MethodTest_PassFirstAndLast_ReturnMessage()
    {
        // Arrange
        TemplateService test = new TemplateService();
        var firstName = new Bogus.Randomizer().Word();
        var lastName = new Bogus.Randomizer().Word();
        // Act
        var result = test.SetName(firstName, lastName);
        // Assert
        Assert.AreEqual($"Hi {firstName} {lastName}! You found my template service.", result.Message);
    }
}
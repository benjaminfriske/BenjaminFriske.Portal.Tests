using Microsoft.VisualStudio.TestTools.UnitTesting;
using BenjaminFriske.Portal.Services;
using System;

namespace BenjaminFriske.Portal.Tests;

[TestClass]
public class TemplateServiceTest
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
    /// Naming your tests
    /// The name of the method being tested.
    /// The scenario under which it's being tested.
    /// The expected behavior when the scenario is invoked.
    /// </summary>

    [TestMethod]
    public void MethodTest_CoverageOnly_ReturnString()
    {
        // Arrange
        TemplateService test = new TemplateService();
        // Act
        var result = test.MethodTest();
        // Assert
        Assert.IsInstanceOfType(result, typeof(string));
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BenjaminFriske.Portal.Services;
namespace BenjaminFriske.Portal.Tests;

[TestClass]
public class TemplateServiceTest
{
    [TestMethod]
    public void FirstMethodTested()
    {
        TemplateService test = new TemplateService();
        test.thisIsForTrav();
    }
}
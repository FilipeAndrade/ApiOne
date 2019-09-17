using ApiOne.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiOne.Tests.UnitTests
{
    [TestClass]
    public class TaxesControllerTest
    {
        [TestMethod]
        public void GetTaxes_Success()
        {
            var controller = new TaxesController();
            
            var response = controller.Get();

            var result = response as OkObjectResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual("0,01", result.Value);
        }
    }
}

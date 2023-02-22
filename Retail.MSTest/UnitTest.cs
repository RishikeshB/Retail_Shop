using Retail.Models.ViewModels;
namespace Retail.MSTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var Expected = "Puma";
            //Act
            ProductViewMsTest product = new();
            ProductViewModel Actual = product.GetByName(Expected);
            //Assert
            Assert.IsNotNull(Actual);
            Assert.AreEqual(Expected, Actual? .Name);
        }
    }
}
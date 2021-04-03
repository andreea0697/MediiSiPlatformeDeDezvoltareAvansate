using MediiSiPlatformeDeDezvoltareAvansate.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediiSiPlatformeDeDezvoltareAvansate.Tests
{
    [TestClass]
    public class LaptopFactoryTests
    {
        [TestMethod]
        public void ConstructAcerLaptop_ShouldReturnAnAcerLaptop()
        {
            var laptopFactory = new LaptopFactory();

            LaptopBuilder acerLaptopBuilder = laptopFactory.ConstructAcerLaptop();

            Assert.IsNotNull(acerLaptopBuilder);
            StringAssert.Contains(acerLaptopBuilder.ToString(), "Acer");
        }

        [TestMethod]
        public void ConstructLenovoLaptop_ShouldReturnAnLenovoLaptop()
        {
            var laptopFactory = new LaptopFactory();

            LaptopBuilder lenovoLaptopBuilder = laptopFactory.ConstructLenovoLaptop();

            Assert.IsNotNull(lenovoLaptopBuilder);
            StringAssert.Contains(lenovoLaptopBuilder.ToString(), "Lenovo");
        }
    }
}

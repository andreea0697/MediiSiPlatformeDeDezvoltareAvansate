using MediiSiPlatformeDeDezvoltareAvansate.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediiSiPlatformeDeDezvoltareAvansate.Tests
{
    [TestClass]
    public class AcerLaptopBuilderTests
    {
        [TestMethod]
        public void BuildMetalFramework_ShouldSetMetalFrameworkCode()
        {
            var acerLaptopBuilder = new AcerLaptopBuilder();

            acerLaptopBuilder.BuildMetalFramework();

            Assert.AreEqual("ACQ-759", acerLaptopBuilder.MetalFramework);
        }

        [TestMethod]
        public void BuildScreen_ShouldSetScreenTypeToFullHD()
        {
            var acerLaptopBuilder = new AcerLaptopBuilder();

            acerLaptopBuilder.BuildScreen();

            Assert.AreEqual("FullHD", acerLaptopBuilder.Screen);
        }

        [TestMethod]
        public void BuildKeyboard_ShouldSetKeyboardToQwerty()
        {
            var acerLaptopBuilder = new AcerLaptopBuilder();

            acerLaptopBuilder.BuildKeyboard();

            Assert.AreEqual("Qwerty", acerLaptopBuilder.Keyboard);
        }

        [TestMethod]
        public void BuildMousePad_ShouldSetMousePadToGlass()
        {
            var acerLaptopBuilder = new AcerLaptopBuilder();

            acerLaptopBuilder.BuildMousePad();

            Assert.AreEqual("Glass", acerLaptopBuilder.MousePad);
        }

        [TestMethod]
        public void BuildSpeakers_ShouldSetTwoSpeakers()
        {
            const int numberOfSpeakers = 2;
            var acerLaptopBuilder = new AcerLaptopBuilder();

            acerLaptopBuilder.BuildSpeakers(numberOfSpeakers);

            StringAssert.Contains(acerLaptopBuilder.Speakers, numberOfSpeakers.ToString());
        }

        [TestMethod]
        public void BuildSpeakers_ShouldContainsDolby()
        {
            const int numberOfSpeakers = 2;
            var acerLaptopBuilder = new AcerLaptopBuilder();

            acerLaptopBuilder.BuildSpeakers(numberOfSpeakers);

            StringAssert.Contains(acerLaptopBuilder.Speakers, "Dolby");
        }
    }
}

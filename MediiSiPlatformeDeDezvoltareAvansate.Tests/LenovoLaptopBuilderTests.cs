using MediiSiPlatformeDeDezvoltareAvansate.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediiSiPlatformeDeDezvoltareAvansate.Tests
{
    [TestClass]
    public class LenovoLaptopBuilderTests
    {
        [TestMethod]
        public void BuildMetalFramework_ShouldSetMetalFrameworkCode()
        {
            var lenovoLaptopBuilder = new LenovoLaptopBuilder();

            lenovoLaptopBuilder.BuildMetalFramework();

            Assert.AreEqual("LXW-726", lenovoLaptopBuilder.MetalFramework);
        }

        [TestMethod]
        public void BuildScreen_ShouldSetScreenTypeToFullHD()
        {
            var lenovoLaptopBuilder = new LenovoLaptopBuilder();

            lenovoLaptopBuilder.BuildScreen();

            Assert.AreEqual("FullHD", lenovoLaptopBuilder.Screen);
        }

        [TestMethod]
        public void BuildKeyboard_ShouldSetKeyboardToQwertyPlusNumPad()
        {
            var lenovoLaptopBuilder = new LenovoLaptopBuilder();

            lenovoLaptopBuilder.BuildKeyboard();

            Assert.AreEqual("Qwerty + NumPad", lenovoLaptopBuilder.Keyboard);
        }

        [TestMethod]
        public void BuildMousePad_ShouldSetMousePadToAbs()
        {
            var lenovoLaptopBuilder = new LenovoLaptopBuilder();

            lenovoLaptopBuilder.BuildMousePad();

            Assert.AreEqual("ABS", lenovoLaptopBuilder.MousePad);
        }

        [TestMethod]
        public void BuildSpeakers_ShouldSetThreeSpeakers()
        {
            const int numberOfSpeakers = 3;
            var lenovoLaptopBuilder = new LenovoLaptopBuilder();

            lenovoLaptopBuilder.BuildSpeakers(numberOfSpeakers);

            StringAssert.Contains(lenovoLaptopBuilder.Speakers, numberOfSpeakers.ToString());
        }

        [TestMethod]
        public void BuildSpeakers_ShouldContainsJbl()
        {
            const int numberOfSpeakers = 3;
            var lenovoLaptopBuilder = new LenovoLaptopBuilder();

            lenovoLaptopBuilder.BuildSpeakers(numberOfSpeakers);

            StringAssert.Contains(lenovoLaptopBuilder.Speakers, "JBL");
        }
    }
}

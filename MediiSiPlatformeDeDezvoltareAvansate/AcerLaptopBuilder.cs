namespace MediiSiPlatformeDeDezvoltareAvansate.Business
{
    public class AcerLaptopBuilder : LaptopBuilder
    {
        public override LaptopBuilder BuildMetalFramework()
        {
            MetalFramework = "ACQ-759";
            return this;
        }

        public override LaptopBuilder BuildScreen()
        {
            Screen = "FullHD";
            return this;
        }

        public override LaptopBuilder BuildKeyboard()
        {
            Keyboard = "Qwerty";
            return this;
        }

        public override LaptopBuilder BuildMousePad()
        {
            MousePad = "Glass";
            return this;
        }

        public override LaptopBuilder BuildSpeakers(int numberOfSpeakers)
        {
            Speakers = $"{numberOfSpeakers}xDolby";
            return this;
        }
    }
}
namespace MediiSiPlatformeDeDezvoltareAvansate.Business
{
    public class LenovoLaptopBuilder : LaptopBuilder
    {
        public override LaptopBuilder BuildMetalFramework()
        {
            MetalFramework = "LXW-726";
            return this;
        }

        public override LaptopBuilder BuildScreen()
        {
            Screen = "FullHD";
            return this;
        }

        public override LaptopBuilder BuildKeyboard()
        {
            Keyboard = "Qwerty + NumPad";
            return this;
        }

        public override LaptopBuilder BuildMousePad()
        {
            MousePad = "ABS";
            return this;
        }

        public override LaptopBuilder BuildSpeakers(int numberOfSpeakers)
        {
            Speakers = $"{numberOfSpeakers}xJBL";
            return this;
        }
    }
}
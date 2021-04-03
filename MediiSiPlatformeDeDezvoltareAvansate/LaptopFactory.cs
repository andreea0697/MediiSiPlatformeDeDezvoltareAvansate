namespace MediiSiPlatformeDeDezvoltareAvansate.Business
{
    public class LaptopFactory
    {
        public LaptopBuilder ConstructAcerLaptop()
        {
            return new AcerLaptopBuilder()
                .BuildMetalFramework()
                .BuildSpeakers(2)
                .BuildKeyboard()
                .BuildMousePad()
                .BuildScreen();
        }

        public LaptopBuilder ConstructLenovoLaptop()
        {
            return new LenovoLaptopBuilder()
                .BuildMetalFramework()
                .BuildScreen()
                .BuildMousePad()
                .BuildKeyboard()
                .BuildSpeakers(3);
        }
    }
}
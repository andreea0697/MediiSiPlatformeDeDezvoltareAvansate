namespace MediiSiPlatformeDeDezvoltareAvansate.Business
{
    public abstract class LaptopBuilder
    {
        public string MetalFramework { get; protected set; }
        public string Screen { get; protected set; }
        public string Keyboard { get; protected set; }
        public string MousePad { get; protected set; }
        public string Speakers { get; protected set; }

        public abstract LaptopBuilder BuildMetalFramework();
        public abstract LaptopBuilder BuildScreen();
        public abstract LaptopBuilder BuildKeyboard();
        public abstract LaptopBuilder BuildMousePad();
        public abstract LaptopBuilder BuildSpeakers(int numberOfSpeakers);

        public override string ToString()
        {
            return $"{GetType().Name.Replace("LaptopBuilder", "")}" +
                   $".\nMetalFramework: {MetalFramework}.\nScreen: {Screen}.\nKeyboard: {Keyboard}.\nMousePad: {MousePad}.\nSpeaker: {Speakers}.\n";
        }
    }
}

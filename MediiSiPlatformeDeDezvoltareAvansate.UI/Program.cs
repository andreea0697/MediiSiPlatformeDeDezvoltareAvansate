using MediiSiPlatformeDeDezvoltareAvansate.Business;
using System;

namespace MediiSiPlatformeDeDezvoltareAvansate.UI
{
    public static class Program
    {
        public static void Main()
        {
            var laptopFactory = new LaptopFactory();

            var acerLaptop = laptopFactory.ConstructAcerLaptop();
            Console.WriteLine(acerLaptop);

            var lenovoLaptop = laptopFactory.ConstructLenovoLaptop();
            Console.WriteLine(lenovoLaptop);
        }
    }
}

using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Apple";
            double price = 15;
            string description = "Amasya Apple";

            Product product = new Product();
            product.Name = "Elma";

            Console.WriteLine("---------Metotlar--------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product);
            sepetManager.Add(product);

            sepetManager.Add2("Armut", "Yeşil Armut", 12);
            sepetManager.Add2("Elma", "Yeşil Elma", 12);
            sepetManager.Add2("Karpuz", "Diyarbakır Karpuzu", 12);
        }
    }
}

//Don't repeat yourself - DRY - Clean Code - Best Practice

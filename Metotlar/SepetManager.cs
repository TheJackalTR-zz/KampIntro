using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler, sepete eklendi : " + product.Name);
        }

        public void Add2(string productName, string description, double price)
        {
            Console.WriteLine("Tebrikler, sepete eklendi : " + productName);
        }
    }
}

using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;

            Console.WriteLine(num1);

            int[] numbs1 = new int[] { 10, 20, 30 };
            int[] numbs2 = new int[] { 100, 200, 300 };
            numbs1 = numbs2;
            numbs2[0] = 999;
        }
    }
}

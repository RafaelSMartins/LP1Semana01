using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Insere 4 números reais entre 0 e 1:");

            string str = Console.ReadLine();

            float f = 0f;
            f = float.Parse(str);

            string f = $"’{0.2: p1}’"

            Console.WriteLine($"{f}");


        
        }
    }
}

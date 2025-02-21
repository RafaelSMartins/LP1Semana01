using System;
using System.Globalization;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Inserir um número inteiro: ");
            string str = Console.ReadLine();

            int i = int.Parse(str);

            Console.WriteLine("Inserir um número real: ");
            string perry = Console.ReadLine();

            float f = 0f;
            f = float.Parse(perry);

            float soma = i + f;

            Console.WriteLine($"soma de {i} mais {f} igual a {soma}");





        }
    }
}

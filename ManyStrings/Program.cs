using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double xx= 1.23456;
            int ii= 19;
            Console.WriteLine($"Número real com duas casas decimais: {xx:F2}");
            Console.WriteLine($"Percentagem com uma casa decimal: {xx:P1}");

            Console.WriteLine($"Hexadecimal: {ii:X}");
            Console.WriteLine($"Moeda: {ii:c}");

            string lyric = "There's a starman waiting in the sky";
            string space= @"And Im floating in a most peculiar way
            And the stars look very different today";
            string something = "MR Penguini\t Channel ";
            Console.WriteLine($"{lyric}, {space}, {something}");


            int age = 3000;
            string immortal="Im IMMORTAL";
            string frase = $"If I have {age} years {immortal}";
            Console.WriteLine(frase);

            
        }
    }
}

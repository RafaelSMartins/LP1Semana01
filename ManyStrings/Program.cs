using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
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

using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string lyric = "There's a starman waiting in the sky";
            string space= @"And I’m floating in a most peculiar way
            And the stars look very different today";
            string something = "MR Penguini\t Channel\U001F427 ";
            Console.WriteLine($"{lyric}, {space}, {something}");
        }
    }
}

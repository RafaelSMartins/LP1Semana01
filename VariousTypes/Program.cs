using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            long scooby=9000000;
            int a=200;
            short  ornintorrinco=90;
            Console.WriteLine($"{ornintorrinco}, {a}, {scooby}");

            char communistSymbol='\u262D';
            char skull='\u2620';
            char musicFlatSign='\u266D';
            Console.WriteLine($"{communistSymbol}, {skull}, {musicFlatSign}");

            float xp=0.90f;
            double patience=19.8d;
            Console.WriteLine($"{xp}, {patience}");

            bool jazz = true;
            bool phonk = false;
            Console.WriteLine($"{jazz}, or {phonk}");
        }
    }
}

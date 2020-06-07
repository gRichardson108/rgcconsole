using System;

namespace rgcconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int seed = random.Next();
            Console.WriteLine($"=============={seed}================");
            Character character = FantasyRandomizer.GenerateRandomCharacterWithSeed(200, seed);
            TextCharacterPrinter.PrintCharacter(character);
            Console.WriteLine();
        }
    }
}

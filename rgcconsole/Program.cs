using System;

namespace rgcconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int seed = random.Next();
                Console.WriteLine("===================================");
                Character character = FantasyRandomizer.GenerateRandomCharacterWithSeed(200, seed);
                Console.WriteLine($"SEED:{seed}");
                TextCharacterPrinter.PrintCharacter(character);
                Console.WriteLine();
            }
        }
    }
}

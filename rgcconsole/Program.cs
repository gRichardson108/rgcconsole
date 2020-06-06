using System;

namespace rgcconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("===================================");
                Character character = FantasyRandomizer.GenerateRandomCharacter(200, out int randomSeed);
                TextCharacterPrinter.PrintCharacter(character);
                Console.WriteLine();
            }
        }
    }
}

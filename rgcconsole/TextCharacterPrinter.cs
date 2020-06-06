using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace rgcconsole
{
    public static class TextCharacterPrinter
    {
        public static void PrintCharacter(Character character, StreamWriter writer=null)
        {
            if (writer == null)
            {
                writer = new StreamWriter(Console.OpenStandardOutput());
                writer.AutoFlush = true;
                Console.SetOut(writer);
            }
            writer.WriteLine($"Profession: {character.Profession}");

            foreach (PrimaryAttribute p in character.primaryAttributes)
            {
                writer.WriteLine($"{p.AttributeType.Name}: {p.Value} [{p.PointsSpent}]");
            }
            foreach (SecondaryAttribute sa in character.secondaryAttributes)
            {
                writer.WriteLine($"{sa.AttributeType.Name}: {sa.Value} [{sa.PointsSpent}]");
            }
        }
    }
}

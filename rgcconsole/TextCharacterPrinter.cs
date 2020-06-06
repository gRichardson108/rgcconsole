using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            Console.WriteLine("-----ADVANTAGES-----");
            var advantages = from t in character.Traits
                             where t.PointValue >= 0
                             orderby t.Name
                             select t;
            foreach (Trait adv in advantages)
            {
                if (adv.Leveled)
                {
                    writer.WriteLine($"{adv.Name} (Level {adv.Level}) [{adv.PointValue}]");
                } else
                {
                    writer.WriteLine($"{adv.Name} [{adv.PointValue}]");
                }
                writer.WriteLine($"\t{adv.Brief}");
            }

            Console.WriteLine("-----DISADVANTAGES-----");
            var disadvantages = from t in character.Traits
                                where t.PointValue < 0
                                orderby t.Name
                                select t;
            foreach (Trait disad in disadvantages)
            {
                if (disad.Leveled)
                {
                    writer.WriteLine($"{disad.Name} (Level {disad.Level}) [{disad.PointValue}]");
                }
                else
                {
                    writer.WriteLine($"{disad.Name} [{disad.PointValue}]");
                }
                if (disad.HasSelfControlRoll)
                {
                    // TODO - these should be randomized as well!
                    writer.WriteLine($"\tControl Roll (CR): 12");
                }
                writer.WriteLine($"\t{disad.Brief}");
            }
        }
    }
}

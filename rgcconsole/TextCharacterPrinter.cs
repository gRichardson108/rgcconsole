using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace rgcconsole
{
    public static class TextCharacterPrinter
    {
        const int TEXT_WRAP_LENGTH = 100;
        public static void PrintCharacter(Character character, StreamWriter writer=null)
        {
            if (writer == null)
            {
                writer = new StreamWriter(Console.OpenStandardOutput());
                writer.AutoFlush = true;
                Console.SetOut(writer);
            }
            writer.WriteLine($"Profession: {character.Profession.Name}    Remaining Points: {character.RemainingPoints}");

            int feet = character.Height / 12;
            int inches = character.Height % 12;
            writer.WriteLine($"Height: {feet}'{inches}\"");
            writer.WriteLine($"Gender: {character.Gender}");


            writer.WriteLine();
            writer.WriteLine("-----ATTRIBUTES-----");
            writer.WriteLine("NAME".PadRight(20) + "LVL".PadRight(5) + "POINTS");
            foreach (PrimaryAttribute p in character.primaryAttributes)
            {
                string label = $"{p.AttributeType.Name} ({p.AttributeType.Abbreviation})".PadRight(20);
                string value = $"{p.Value}".PadRight(5);
                string points = $"[{p.PointsSpent}]";
                writer.WriteLine(label + value + points);
            }
            foreach (SecondaryAttribute sa in character.secondaryAttributes)
            {
                string label = $"{sa.AttributeType.Name} ({sa.AttributeType.Abbreviation})".PadRight(20);
                string value = $"{sa.Value}".PadRight(5);
                string points = $"[{sa.PointsSpent}]";
                writer.WriteLine(label + value + points);
            }

            writer.WriteLine();
            writer.WriteLine("-----ADVANTAGES-----");
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
                WriteLineWordWrap(writer, adv.Brief, TEXT_WRAP_LENGTH);
            }
            writer.WriteLine();
            writer.WriteLine("-----DISADVANTAGES-----");
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
                WriteLineWordWrap(writer, disad.Brief, TEXT_WRAP_LENGTH);
            }
            writer.WriteLine();
            writer.WriteLine("-----SKILLS------------");
            var skills = from s in character.Skills
                         orderby s.Name
                         select s;
            const string NAME_LABEL = "NAME                   ";
            const string LEVEL_LABEL = "LEVEL   ";
            const string RELATIVE_LABEL = "RELATIVE   ";
            const string POINTS_LABEL = "POINTS";

            writer.WriteLine(NAME_LABEL + LEVEL_LABEL + RELATIVE_LABEL + POINTS_LABEL);
            var allSkills = from s in character.Profession.SkillWeights.Keys
                            orderby s.Name
                            select s;
            foreach (Skill a in allSkills)
            {
                Skill match = character.Skills.Find(m => m.Name == a.Name);
                Skill s = a;
                if (match != null)
                {
                    s = match;
                }
                string name = s.Name.PadRight(NAME_LABEL.Length, ' ');
                int effectiveLevelNum = (int)s.BaseAttribute.GetCharacterAttribute(character).Value + s.CurrentSkillLevel;
                string effectiveLevel = $"{effectiveLevelNum}".PadRight(LEVEL_LABEL.Length, ' ');
                string relativeString = $"{s.BaseAttribute.Abbreviation}{s.CurrentSkillLevel.ToString("+0;-#")}".PadRight(RELATIVE_LABEL.Length, ' ');
                string pointsString = $"[{s.PointsSpent}]".PadRight(POINTS_LABEL.Length, ' ');
                writer.WriteLine($"{name}{effectiveLevel}{relativeString}[{s.PointsSpent}]");
            }
        }

        // <summary>
        ///     Writes the specified data, followed by the current line terminator, to the standard output stream, while wrapping lines that would otherwise break words.
        /// </summary>
        /// <param name="paragraph">The value to write.</param>
        /// <param name="tabSize">The value that indicates the column width of tab characters.</param>
        public static void WriteLineWordWrap(StreamWriter writer, string paragraph, int width, int tabSize = 8)
        {
            string[] lines = paragraph
                .Replace("\t", new String(' ', tabSize))
                .Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            for (int i = 0; i < lines.Length; i++)
            {
                string process = lines[i];
                List<String> wrapped = new List<string>();

                while (process.Length > width)
                {
                    int wrapAt = process.LastIndexOf(' ', Math.Min(width - 1, process.Length));
                    if (wrapAt <= 0) break;

                    wrapped.Add(process.Substring(0, wrapAt));
                    process = process.Remove(0, wrapAt + 1);
                }

                foreach (string wrap in wrapped)
                {
                    writer.WriteLine("\t" + wrap);
                }

                writer.WriteLine("\t" + process);
            }
        }
    }
}

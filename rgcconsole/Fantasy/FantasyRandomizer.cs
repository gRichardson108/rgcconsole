using MathNet.Numerics.Providers.LinearAlgebra;
using rgcconsole.Fantasy;
using rgcconsole.Fantasy.Professions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.Distributions;

namespace rgcconsole
{
    class FantasyRandomizer
    {
        private static List<IProfession> professions = new List<IProfession>
        {
            new Barbarian(),
            new Scout(),
            new Knight(),
        };

        public static Character GenerateRandomCharacter(int pointTotal, out int randomSeed)
        {
            // save the random seed so we can output it
            randomSeed = Environment.TickCount;

            Character character = GenerateRandomCharacterWithSeed(pointTotal, randomSeed);

            return character;
        }

        public static Character GenerateRandomCharacterWithSeed(int pointTotal, int randomSeed)
        {
            Random random = new Random(randomSeed);

            Character character = new Character();
            IProfession profession = professions.PickRandom(random);
            character.Profession = profession.Name;
            int remainingPoints = pointTotal;

            List<KeyValuePair<AttributeType, float>> attrWeights = 
                new List<KeyValuePair<AttributeType, float>>(profession.PrimaryAttributeWeights.ToList());
            attrWeights.AddRange(profession.SecondaryAttributeWeights.ToList());
            foreach ( (AttributeType type, float weight) in attrWeights)
            {
                CharacterAttribute attr = type.GetCharacterAttribute(character);

                // do a little randomization for flavor so we occasionally get something
                // different from the template
                Normal normalDist = new Normal(weight, .03);
                int pointsToSpend = (int) Math.Floor(normalDist.Sample() * pointTotal);
                
                attr.SpendPoints(pointsToSpend, out int extra);
                remainingPoints -= (pointsToSpend - extra);
            }

            Console.WriteLine($"Remaining points: {remainingPoints}");
            return character;
        }
    }
    public static class EnumerableExtension
    {
        public static T PickRandom<T>(this IEnumerable<T> source, Random random)
        {
            int count = source.Count();
            return source.ElementAt(random.Next(count));
        }
    }
}

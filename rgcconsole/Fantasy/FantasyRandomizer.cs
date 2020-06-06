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

            // randomize the primary/secondary attributes
            List<KeyValuePair<AttributeType, float>> attrWeights =
               new List<KeyValuePair<AttributeType, float>>(profession.PrimaryAttributeWeights.ToList());
            attrWeights.AddRange(profession.SecondaryAttributeWeights.ToList());
            foreach ((AttributeType type, float weight) in attrWeights)
            {
                CharacterAttribute attr = type.GetCharacterAttribute(character);

                // update secondary attributes since they are based on primaries
                if (attr is SecondaryAttribute)
                {
                    (attr as SecondaryAttribute).Recalculate(character);
                }

                // do a little randomization for flavor so we occasionally get something
                // different from the template
                Normal normalDist = new Normal(weight, 0.03, random);
                int pointsToSpend = (int) Math.Floor(normalDist.Sample() * pointTotal);
                
                attr.SpendPoints(pointsToSpend, out int extra);
                remainingPoints -= (pointsToSpend - extra);
            }

            // buy mandatory traits
            foreach (Trait t in profession.MandatoryTraits)
            {
                Trait toAdd = t; // copies since Traits are value-typed
                toAdd.Level += 1;
                remainingPoints -= toAdd.PointValue;
                character.Traits.Add(toAdd);
            }

            // randomize the advantages
            List<KeyValuePair<Trait, float>> traitWeights = 
                new List<KeyValuePair<Trait, float>>(profession.AdvantageWeights.ToList());
            traitWeights.AddRange(profession.DisadvantageWeights.ToList());
            foreach ((Trait t, float weight) in traitWeights)
            {
                Normal normalDist = new Normal(weight, 0.015, random);
                int pointsToSpend = (int)Math.Floor(normalDist.Sample() * pointTotal);
                if (pointsToSpend >= t.PointValue)
                {
                    Trait toAdd = t;//copy the trait before we modify it
                    // buy one level
                    toAdd.Level += 1;
                    remainingPoints -= t.PointValue;
                    pointsToSpend -= t.PointValue;
                    // if it's a leveled trait, buy multiple levels
                    if (t.Leveled)
                    {
                        while (pointsToSpend >= t.PointValue)
                        {
                            toAdd.Level += 1;                            
                            remainingPoints -= t.PointValue;
                            pointsToSpend -= t.PointValue;
                        }
                    }
                    toAdd.PointValue = t.PointValue * toAdd.Level;
                    character.Traits.Add(toAdd);
                }
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

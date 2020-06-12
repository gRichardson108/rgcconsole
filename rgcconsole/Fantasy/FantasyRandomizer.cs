using MathNet.Numerics.Providers.LinearAlgebra;
using rgcconsole.Fantasy;
using rgcconsole.Fantasy.Professions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.Distributions;
using System.Drawing;
using System.Runtime.InteropServices;

namespace rgcconsole
{
    public class FantasyRandomizer
    {
        private static List<IProfession> professions = new List<IProfession>
        {
            new Barbarian(),
            new Scout(),
            new Knight(),
            new Thief(),
            new HolyWarrior(),
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
            character.Profession = profession;
            int remainingPoints = pointTotal;

            // randomize the primary/secondary attributes
            List<KeyValuePair<AttributeType, float>> attrWeights =
               new List<KeyValuePair<AttributeType, float>>(profession.PrimaryAttributeWeights.ToList());
            attrWeights.AddRange(profession.SecondaryAttributeWeights.ToList());

            var attrWeightsShuffled = from a in attrWeights
                                      orderby random.Next()
                                      select a;
            foreach ((AttributeType type, float weight) in attrWeightsShuffled)
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

            var traitWeightsShuffled = from t in traitWeights
                                       orderby random.Next()
                                       select t;
            foreach ((Trait t, float weight) in traitWeightsShuffled)
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

            // randomize the skills
            List<KeyValuePair<FantasyGameSkill, float>> skillWeights = new List<KeyValuePair<FantasyGameSkill, float>>(profession.SkillWeights.ToList());
            var skillsShuffled = from skill in skillWeights
                                 orderby random.Next()
                                 select skill;
            foreach ((FantasyGameSkill skill, float weight) in skillsShuffled)
            {
                Normal normalDist = new Normal(weight, 0.004, random);
                int pointsToSpend = (int)Math.Floor(normalDist.Sample() * pointTotal);
                // skip negative or 0 point value skills
                if (pointsToSpend < 1)
                {
                    continue;
                }

                FantasyGameSkill mySkill = new FantasyGameSkill(skill.BaseAttribute, skill.Difficulty)
                {
                    Name = skill.Name,
                    Description = skill.Description,
                };
                // don't attempt to spend more points than we have left
                if (pointsToSpend > remainingPoints)
                {
                    pointsToSpend = remainingPoints;
                }

                mySkill.SpendPoints(pointsToSpend, out int extra);
                remainingPoints -= (pointsToSpend - extra);

                character.Skills.Add(mySkill);

                if (remainingPoints == 0)
                {
                    // stop here if we've spent exactly as many as we can
                    break;
                }
            }

            // what to do with leftover points?
            if (remainingPoints > 0)
            {
                // improve low skills
                var lowSkills = from s in character.Skills
                                where s.PointsSpent < (skillWeights.Find(m => m.Key.Name == s.Name).Value * pointTotal * 1.02f)
                                orderby (random.Next()) // shuffle list
                                select s;
                foreach (FantasyGameSkill skill in lowSkills)
                {
                    if (remainingPoints >= 4)
                    {
                        skill.SpendPoints(4, out int uselessPoints);
                        remainingPoints -= (4 - uselessPoints);
                    } else
                    {
                        break;
                    }
                }

                var professionAdv = from s in traitWeights
                                    where s.Key.PointValue > 0 && s.Key.PointValue <= remainingPoints
                                    where character.Traits.Find(m=> m.Name == s.Key.Name).Name == "" //find missing trait
                                    orderby (random.Next())
                                    select s.Key;
                foreach (Trait t in professionAdv)
                {
                    if (remainingPoints >= t.PointValue)
                    {
                        Trait toAdd = t;// copy the trait before we modify it
                                        // buy one level
                        toAdd.Level += 1;
                        remainingPoints -= t.PointValue;
                        // if it's a leveled trait, buy multiple levels
                        if (t.Leveled)
                        {
                            // buy up to 3 levels
                            int i = 0;
                            while (remainingPoints >= t.PointValue && i++ < 3)
                            {
                                toAdd.Level += 1;
                                remainingPoints -= t.PointValue;
                            }
                        }
                        toAdd.PointValue = t.PointValue * toAdd.Level;
                        character.Traits.Add(toAdd);
                    }
                }
            }


            var genderNormal = new Normal(random);
            var sample = genderNormal.Sample();
            Normal heightNormal;
            if (sample > 0.01)
            {
                character.Gender = "Male";
                heightNormal = new Normal(70, 3, random);
            } else if (sample < -0.011)
            {
                character.Gender = "Female";
                heightNormal = new Normal(64, 3, random);
            } else
            {
                character.Gender = "Nonbinary";
                heightNormal = new Normal(67.5, 3, random);
            }

            character.Height = (int) Math.Round(heightNormal.Sample());
            character.RemainingPoints = remainingPoints;
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

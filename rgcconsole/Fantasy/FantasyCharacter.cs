using System;
using System.Collections.Generic;
using System.Text;

namespace rgcconsole.Fantasy
{
    public class FantasyGameSkill : Skill
    {
        public AttributeType BaseAttribute { get; }

        public FantasySkillDifficulty Difficulty { get; }

        public FantasyGameSkill(AttributeType attribute, FantasySkillDifficulty difficulty)
        {
            BaseAttribute = attribute;
            Difficulty = difficulty;
        }

        public override int EffectiveSkillLevel => throw new NotImplementedException();

        /// <summary>
        /// My fantasy skills are simplified, we're going to use "Very Hard" costs for the
        /// broadest skills, and "Average" for the specialized skills.
        /// </summary>
        /// <param name="EffectiveSkillLevel"></param>
        /// <returns></returns>
        public override int CalculatePointCost(int EffectiveSkillLevel)
        {
            int offset = 0; // higher offset shifts the skill costs to make them more difficult

            if (Difficulty == FantasySkillDifficulty.Broad)
            {
                offset = 2; // broad skills are slightly more expensive
            }
            int skillMinimum = -(offset + 1);

            if (EffectiveSkillLevel < skillMinimum)
            {
                throw new ArgumentOutOfRangeException($"Effective skill {EffectiveSkillLevel} is below the skill minimum of {skillMinimum}");
            } else if (EffectiveSkillLevel == skillMinimum)
            {
                return 1;
            } else if (EffectiveSkillLevel == skillMinimum + 1)
            {
                return 2;
            } else
            {
                return (EffectiveSkillLevel + offset) * 4;
            }
        }

        public override int PointCost()
        {
            return CalculatePointCost(CurrentSkillLevel);
        }

        public enum FantasySkillDifficulty
        {
            Specialized,//equivalent to "average" skills in GURPS
            Broad       //equivalent to "Very Hard" skills in GURPS
        }
    }

    public class FantasyGameSpell : Skill
    {
        public CharacterAttribute BaseAttribute { get; }

        public FantasySpellDifficulty Difficulty { get; }

        public FantasyGameSpell(CharacterAttribute attribute, FantasySpellDifficulty difficulty)
        {
            BaseAttribute = attribute;
            Difficulty = difficulty;
        }

        public override int EffectiveSkillLevel => throw new NotImplementedException();

        public override int CalculatePointCost(int EffectiveSkillLevel)
        {
            int offset = 1; // higher offset shifts the skill costs to make them more difficult

            if (Difficulty == FantasySpellDifficulty.VeryHard)
            {
                offset = 2; // broad skills are slightly more expensive
            }
            int skillMinimum = -(offset + 1);

            if (EffectiveSkillLevel < skillMinimum)
            {
                throw new ArgumentOutOfRangeException($"Effective skill {EffectiveSkillLevel} is below the skill minimum of {skillMinimum}");
            }
            else if (EffectiveSkillLevel == skillMinimum)
            {
                return 1;
            }
            else if (EffectiveSkillLevel == skillMinimum + 1)
            {
                return 2;
            }
            else
            {
                return (EffectiveSkillLevel + offset) * 4;
            }
        }

        public override int PointCost()
        {
            throw new NotImplementedException();
        }

        public enum FantasySpellDifficulty
        {
            Hard,
            VeryHard
        }
    }
}

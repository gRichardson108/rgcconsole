using System;
using System.Collections.Generic;
using System.Text;

namespace rgcconsole.Fantasy
{
    public class FantasyGameSkill : Skill
    {

        public FantasySkillDifficulty Difficulty { get; }

        public FantasyGameSkill(AttributeType attribute, FantasySkillDifficulty difficulty)
        {
            BaseAttribute = attribute;
            Difficulty = difficulty;
        }

        /// <summary>
        /// My fantasy skills are simplified, we're going to use "Very Hard" costs for the
        /// broadest skills, and "Average" for the specialized skills.
        /// </summary>
        /// <param name="EffectiveSkillLevel"></param>
        /// <returns></returns>
        public override void SpendPoints(int pointsToSpend, out int uselesslySpentPoints)
        {
            int offset = 0; // higher offset shifts the skill costs to make them more difficult

            if (Difficulty == FantasySkillDifficulty.Broad)
            {
                offset = 2; // broad skills are slightly more expensive
            }
            int skillMinimum = -(offset + 1);

            while (pointsToSpend > 0)
            {
                if (CurrentSkillLevel < skillMinimum && pointsToSpend >= 1)
                {
                    pointsToSpend -= 1;
                    PointsSpent += 1;
                    CurrentSkillLevel = skillMinimum;
                }
                else if (CurrentSkillLevel == skillMinimum && pointsToSpend >= 2)
                {
                    pointsToSpend -= 2;
                    PointsSpent += 2;
                    CurrentSkillLevel = skillMinimum + 1;
                }
                else if (pointsToSpend >= 4)
                {
                    pointsToSpend -= 4;
                    PointsSpent += 4;
                    CurrentSkillLevel += 1;
                }
                else
                {
                    uselesslySpentPoints = pointsToSpend;
                    return;
                }
            }
            uselesslySpentPoints = 0;
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

        public override void SpendPoints(int pointsToSpend, out int uselesslySpentPoints)
        {
            int offset = 1; // higher offset shifts the skill costs to make them more difficult

            if (Difficulty == FantasySpellDifficulty.VeryHard)
            {
                offset = 2; // broad skills are slightly more expensive
            }
            int skillMinimum = -(offset + 1);

            while (pointsToSpend > 0)
            {
                if (CurrentSkillLevel < skillMinimum && pointsToSpend >= 1)
                {
                    pointsToSpend -= 1;
                    PointsSpent += 1;
                    CurrentSkillLevel = skillMinimum;
                }
                else if (CurrentSkillLevel == skillMinimum && pointsToSpend >= 2)
                {
                    pointsToSpend -= 2;
                    PointsSpent += 2;
                    CurrentSkillLevel = skillMinimum + 1;
                }
                else if (pointsToSpend >= 4)
                {
                    pointsToSpend -= 4;
                    PointsSpent += 4;
                    CurrentSkillLevel += 1;
                }
                else
                {
                    // not enough point to get to next level
                    uselesslySpentPoints = pointsToSpend;
                    return;
                }
            }
            uselesslySpentPoints = 0;
        }

        public enum FantasySpellDifficulty
        {
            Hard,
            VeryHard
        }
    }
}

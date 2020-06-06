using rgcconsole.Fantasy.Skills;
using rgcconsole.Fantasy.Traits;
using System;
using System.Collections.Generic;
using System.Text;

namespace rgcconsole.Fantasy.Professions
{
    public class Barbarian : IProfession
    {
        public string Name { get; set; } = "Barbarian";

        public Dictionary<AttributeType, float> PrimaryAttributeWeights { get; set; } = new Dictionary<AttributeType, float>
        {
            { AttributeType.ST, 0.431373f },
            { AttributeType.DX, 0.235294f },
            { AttributeType.IQ, -0.07843f },
            { AttributeType.HT, 0.156863f },
        };

        public Dictionary<AttributeType, float> SecondaryAttributeWeights { get; set; } = new Dictionary<AttributeType, float>
        {
            { AttributeType.HitPoints, 0.039216f },
            { AttributeType.Will, 0f },
            { AttributeType.Perception, 0.058824f },
            { AttributeType.FatiguePoints, 0f },
            { AttributeType.BasicSpeed, -0.03922f },
            { AttributeType.BasicMove, 0f },
        };

        public Dictionary<Trait, float> AdvantageWeights { get; set; } = new Dictionary<Trait, float>
        {
            { FantasyAdvantages.RapidHealing, 0.02f },
            { FantasyAdvantages.Fearless, 0.02f },
            { FantasyAdvantages.Luck, 0.02f },
            { FantasyAdvantages.CombatReflexes, 0.03f },
            { FantasyAdvantages.AnimalEmpathy, 0.03f },
            { FantasyAdvantages.DangerSense, 0.02f },
            { FantasyAdvantages.MagicResistance, 0.02f },
            { FantasyAdvantages.PenetratingVoice, 0.02f },
            { FantasyAdvantages.Appearance, 0.02f },
        };

        public Dictionary<Trait, float> DisadvantageWeights { get; set; } = new Dictionary<Trait, float>
        {
            { FantasyDisadvantages.OdiousPersonalHabit, 0.05f },
            { FantasyDisadvantages.Illiteracy, 0.01f },
            { FantasyDisadvantages.SenseOfDutyCompanions, 0.03f },
            { FantasyDisadvantages.OutlawHonor, 0.03f },
            { FantasyDisadvantages.Berserk, 0.03f },
            { FantasyDisadvantages.Bloodlust, 0.03f },
        };

        public Dictionary<FantasyGameSkill, float> SkillWeights { get; set; } = new Dictionary<FantasyGameSkill, float>
        {
        };

        public Dictionary<FantasyGameSpell, float> SpellWeights { get; set; } = new Dictionary<FantasyGameSpell, float>
        {

        };
        public List<Trait> MandatoryTraits { get; set; } = new List<Trait>()
        {
            FantasyAdvantages.HighPainThreshold,
            FantasyAdvantages.Fit,
        };
        public List<FantasyGameSkill> MandatorySkill { get; set; } = new List<FantasyGameSkill>() 
        {
            FantasySkills.Survival,
        };
    }

    public class Scout : IProfession
    {
        public string Name { get; set; } = "Scout";
        public Dictionary<AttributeType, float> PrimaryAttributeWeights { get; set; } = new Dictionary<AttributeType, float>
        {
            { AttributeType.ST, 0.039683f },
            { AttributeType.DX, 0.396825f },
            { AttributeType.IQ, 0.079365f },
            { AttributeType.HT, 0.079365f },
        };

        public Dictionary<AttributeType, float> SecondaryAttributeWeights { get; set; } = new Dictionary<AttributeType, float>
        {
            { AttributeType.HitPoints, 0f },
            { AttributeType.Will, 0f },
            { AttributeType.Perception, 0.058824f },
            { AttributeType.FatiguePoints, 0.039683f },
            { AttributeType.BasicSpeed, 0.039683f },
            { AttributeType.BasicMove, 0.039683f },
        };

        public Dictionary<Trait, float> AdvantageWeights { get; set; } = new Dictionary<Trait, float>
        {
            { FantasyAdvantages.RapidHealing, 0.02f },
            { FantasyAdvantages.Fearless, 0.02f },
            { FantasyAdvantages.Luck, 0.02f },
            { FantasyAdvantages.CombatReflexes, 0.03f },
            { FantasyAdvantages.AnimalEmpathy, 0.03f },
            { FantasyAdvantages.DangerSense, 0.02f },
            { FantasyAdvantages.PenetratingVoice, 0.02f },
            { FantasyAdvantages.Appearance, 0.02f },
        };

        public Dictionary<Trait, float> DisadvantageWeights { get; set; } = new Dictionary<Trait, float>
        {
            { FantasyDisadvantages.OdiousPersonalHabit, 0.02f },
            { FantasyDisadvantages.Illiteracy, 0.005f },
            { FantasyDisadvantages.SenseOfDutyCompanions, 0.03f },
            { FantasyDisadvantages.SoldiersHonor, 0.02f },
            { FantasyDisadvantages.OutlawHonor, 0.03f },
            { FantasyDisadvantages.Greed, 0.01f },
            { FantasyDisadvantages.Xenophilia, 0.02f },
        };

        public Dictionary<FantasyGameSkill, float> SkillWeights { get; set; } = new Dictionary<FantasyGameSkill, float>
        {
        };

        public Dictionary<FantasyGameSpell, float> SpellWeights { get; set; } = new Dictionary<FantasyGameSpell, float>
        {

        };
        public List<Trait> MandatoryTraits { get; set; } = new List<Trait>()
        {
            FantasyAdvantages.AbsoluteDirection,
            FantasyAdvantages.Fit,
        };

        public List<FantasyGameSkill> MandatorySkill { get; set; } = new List<FantasyGameSkill>();
    }

    public class Knight : IProfession
    {
        public string Name { get; set; } = "Knight";
        public Dictionary<AttributeType, float> PrimaryAttributeWeights { get; set; } = new Dictionary<AttributeType, float>
        {
            { AttributeType.ST, 0.24f },
            { AttributeType.DX, 0.32f },
            { AttributeType.IQ, 0f },
            { AttributeType.HT, 0.12f },
        };

        public Dictionary<AttributeType, float> SecondaryAttributeWeights { get; set; } = new Dictionary<AttributeType, float>
        {
            { AttributeType.HitPoints, 0f },
            { AttributeType.Will, 0f },
            { AttributeType.Perception, 0f },
            { AttributeType.FatiguePoints, 0f },
            { AttributeType.BasicSpeed, -0.04f},
            { AttributeType.BasicMove, 0f },
        };

        public Dictionary<Trait, float> AdvantageWeights { get; set; } = new Dictionary<Trait, float>
        {
            { FantasyAdvantages.RapidHealing, 0.02f },
            { FantasyAdvantages.Fearless, 0.08f },
            { FantasyAdvantages.Luck, 0.02f },
            { FantasyAdvantages.CombatReflexes, 0.03f },
            { FantasyAdvantages.PenetratingVoice, 0.02f },
            { FantasyAdvantages.Appearance, 0.02f },
        };

        public Dictionary<Trait, float> DisadvantageWeights { get; set; } = new Dictionary<Trait, float>
        {
            { FantasyDisadvantages.SenseOfDutyCompanions, 0.03f },
            { FantasyDisadvantages.ChivalryHonor, 0.03f },
            { FantasyDisadvantages.Bloodlust, 0.02f },
            { FantasyDisadvantages.NoSenseOfHumor, 0.015f },
            { FantasyDisadvantages.Chummy, 0.02f },
            { FantasyDisadvantages.Truthfulness, 0.02f },
        };

        public Dictionary<FantasyGameSkill, float> SkillWeights { get; set; } = new Dictionary<FantasyGameSkill, float>
        {
        };

        public Dictionary<FantasyGameSpell, float> SpellWeights { get; set; } = new Dictionary<FantasyGameSpell, float>
        {

        };
        public List<Trait> MandatoryTraits { get; set; } = new List<Trait>();
        public List<FantasyGameSkill> MandatorySkill { get; set; } = new List<FantasyGameSkill>();
    }
}

using rgcconsole.Fantasy.Skills;
using rgcconsole.Fantasy.Traits;
using System.Collections.Generic;

namespace rgcconsole.Fantasy.Professions
{
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
            { PowerUps.HeroicArcher, 0.03f }
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
            { FantasySkills.Academia, -0.01f },
            { FantasySkills.Acrobatics, 0.01f },
            { FantasySkills.Administration, -0.01f },
            { FantasySkills.AnimalHandling, 0.01f },
            { FantasySkills.Athletics, 0.02f },
            { FantasySkills.Craft, 0.005f },
            { FantasySkills.Engineering, 0f },
            { FantasySkills.Singing, 0.01f },
            { FantasySkills.Dancing, 0.01f },
            { FantasySkills.Sculpting, 0f },
            { FantasySkills.Music, 0.01f },
            { FantasySkills.Storytelling, 0.01f },
            { FantasySkills.Puppetry, 0f },
            { FantasySkills.Painting, 0f },
            { FantasySkills.Humanities, 0f },
            { FantasySkills.Intrusion, 0.01f },
            { FantasySkills.Investigation, 0.01f },
            { FantasySkills.Medicine, 0.005f },
            { FantasySkills.Meditation, 0f },
            { FantasySkills.Mysticism, 0.008f },
            { FantasySkills.Persuasion, 0f },
            { FantasySkills.Psychology, 0f },
            { FantasySkills.ScienceAlchemy, -0.008f },
            { FantasySkills.ScienceMathematics, -0.008f },
            { FantasySkills.ScienceAstronomy, 0f },
            { FantasySkills.ScienceNature, 0f },
            { FantasySkills.ScienceGeology, 0f },
            { FantasySkills.Stealth, 0.02f },
            { FantasySkills.Streetwise, 0.01f },
            { FantasySkills.Survival, 0.03f },
            { FantasySkills.Tactics, 0.01f },
            { FantasySkills.Trickery, 0.01f },
            { FantasySkills.Vehicle, 0f },
            { CombatSkills.Archery, 0.08f },
            { CombatSkills.BladedWeapon, 0.01f },
            { CombatSkills.BluntWeapon, 0.008f },
            { CombatSkills.Crossbows, 0.05f },
            { CombatSkills.Firearms, 0.01f },
            { CombatSkills.Shield, -0.02f },
            { CombatSkills.UnarmedStrikes, 0.008f },
            { CombatSkills.Wrestling, 0.008f },
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
}

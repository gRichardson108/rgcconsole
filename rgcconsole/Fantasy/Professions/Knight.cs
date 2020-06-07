using rgcconsole.Fantasy.Skills;
using rgcconsole.Fantasy.Traits;
using System;
using System.Collections.Generic;
using System.Text;

namespace rgcconsole.Fantasy.Professions
{
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
            { PowerUps.ArmorMastery, 0.02f }
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
            { FantasySkills.Academia, 0f },
            { FantasySkills.Acrobatics, -0.008f },
            { FantasySkills.Administration, 0.01f },
            { FantasySkills.AnimalHandling, 0.02f },
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
            { FantasySkills.Humanities, 0.01f },
            { FantasySkills.Intrusion, 0.008f },
            { FantasySkills.Investigation, 0.01f },
            { FantasySkills.Medicine, 0.005f },
            { FantasySkills.Meditation, 0.008f },
            { FantasySkills.Mysticism, 0.008f },
            { FantasySkills.Persuasion, 0.01f },
            { FantasySkills.Psychology, 0.008f },
            { FantasySkills.ScienceAlchemy, -0.008f },
            { FantasySkills.ScienceMathematics, -0.008f },
            { FantasySkills.ScienceAstronomy, -0.008f },
            { FantasySkills.ScienceNature, -0.008f },
            { FantasySkills.ScienceGeology, -0.008f },
            { FantasySkills.Stealth, 0f },
            { FantasySkills.Streetwise, 0f },
            { FantasySkills.Survival, 0f },
            { FantasySkills.Tactics, 0.02f },
            { FantasySkills.Trickery, 0f },
            { FantasySkills.Vehicle, 0.01f },
            { CombatSkills.Archery, 0.008f },
            { CombatSkills.BladedWeapon, 0.15f },
            { CombatSkills.BluntWeapon, 0.15f },
            { CombatSkills.Crossbows, 0.008f },
            { CombatSkills.Firearms, 0.008f },
            { CombatSkills.Shield, 0.03f },
            { CombatSkills.UnarmedStrikes, 0.01f },
            { CombatSkills.Wrestling, 0.01f },
        };

        public Dictionary<FantasyGameSpell, float> SpellWeights { get; set; } = new Dictionary<FantasyGameSpell, float>
        {

        };
        public List<Trait> MandatoryTraits { get; set; } = new List<Trait>();
        public List<FantasyGameSkill> MandatorySkill { get; set; } = new List<FantasyGameSkill>();
    }
}

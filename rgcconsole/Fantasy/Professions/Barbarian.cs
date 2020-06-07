using rgcconsole.Fantasy.Skills;
using rgcconsole.Fantasy.Traits;
using System.Collections.Generic;

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
            { PowerUps.ToughSkin, 0.02f },
            { PowerUps.Daredevil, 0.02f },
            { PowerUps.DiscriminatorySmell, 0.02f },
            { PowerUps.Catfall, 0.02f },
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
            { FantasySkills.Academia, -0.01f },
            { FantasySkills.Acrobatics, 0.01f },
            { FantasySkills.Administration, -0.01f },
            { FantasySkills.AnimalHandling, 0.01f },
            { FantasySkills.Athletics, 0.02f },
            { FantasySkills.Craft, 0f },
            { FantasySkills.Engineering, 0f },
            { FantasySkills.Singing, 0.01f },
            { FantasySkills.Dancing, 0.01f },
            { FantasySkills.Sculpting, 0f },
            { FantasySkills.Music, 0f },
            { FantasySkills.Storytelling, 0.01f },
            { FantasySkills.Puppetry, 0f },
            { FantasySkills.Painting, 0f },
            { FantasySkills.Humanities, 0f },
            { FantasySkills.Intrusion, 0.005f },
            { FantasySkills.Investigation, 0f },
            { FantasySkills.Medicine, 0.005f },
            { FantasySkills.Meditation, 0f },
            { FantasySkills.Mysticism, 0.008f },
            { FantasySkills.Persuasion, 0f },
            { FantasySkills.Psychology, 0f },
            { FantasySkills.ScienceAlchemy, -0.008f },
            { FantasySkills.ScienceMathematics, -0.008f },
            { FantasySkills.ScienceAstronomy, -0.008f },
            { FantasySkills.ScienceNature, 0f },
            { FantasySkills.ScienceGeology, -0.008f },
            { FantasySkills.Stealth, 0.01f },
            { FantasySkills.Streetwise, 0.01f },
            { FantasySkills.Survival, 0.03f },
            { FantasySkills.Tactics, 0.01f },
            { FantasySkills.Trickery, 0.01f },
            { FantasySkills.Vehicle, 0f },
            { CombatSkills.Archery, 0.004f },
            { CombatSkills.BladedWeapon, 0.1f },
            { CombatSkills.BluntWeapon, 0.1f },
            { CombatSkills.Crossbows, 0f },
            { CombatSkills.Firearms, 0f },
            { CombatSkills.Shield, 0.01f },
            { CombatSkills.UnarmedStrikes, 0.008f },
            { CombatSkills.Wrestling, 0.008f },
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
}

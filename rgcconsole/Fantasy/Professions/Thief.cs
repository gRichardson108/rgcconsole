using rgcconsole.Fantasy.Skills;
using rgcconsole.Fantasy.Traits;
using System.Collections.Generic;

namespace rgcconsole.Fantasy.Professions
{
    public class Thief : IProfession
    {
        public string Name { get; set; } = "Thief";

        public Dictionary<AttributeType, float> PrimaryAttributeWeights { get; set; } = new Dictionary<AttributeType, float>
        {
            { AttributeType.ST, 0f },
            { AttributeType.DX, 0.435294f },
            { AttributeType.IQ, 0.27843f },
            { AttributeType.HT, 0.016863f },
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
            { FantasyAdvantages.DangerSense, 0.02f },
            { FantasyAdvantages.MagicResistance, 0.02f },
            { FantasyAdvantages.Appearance, 0.02f },
            { FantasyAdvantages.Charisma, 0.02f },
            { PowerUps.Catfall, 0.02f },
            { PowerUps.Gizmo, 0.02f },
        };

        public Dictionary<Trait, float> DisadvantageWeights { get; set; } = new Dictionary<Trait, float>
        {
            { FantasyDisadvantages.OdiousPersonalHabit, 0.05f },
            { FantasyDisadvantages.Illiteracy, -0.02f },
            { FantasyDisadvantages.SenseOfDutyCompanions, 0.03f },
            { FantasyDisadvantages.OutlawHonor, 0.03f },
            { FantasyDisadvantages.Greed, 0.03f },
            { FantasyDisadvantages.Chummy, 0.02f },
            { FantasyDisadvantages.Curious, 0.03f },
        };

        public Dictionary<FantasyGameSkill, float> SkillWeights { get; set; } = new Dictionary<FantasyGameSkill, float>
        {
            { FantasySkills.Academia, 0.0f },
            { FantasySkills.Acrobatics, 0.02f },
            { FantasySkills.Administration, 0.01f },
            { FantasySkills.AnimalHandling, 0.01f },
            { FantasySkills.Athletics, 0.02f },
            { FantasySkills.Craft, 0.025f },
            { FantasySkills.Engineering, 0f },
            { FantasySkills.Singing, 0.01f },
            { FantasySkills.Dancing, 0.01f },
            { FantasySkills.Sculpting, 0f },
            { FantasySkills.Music, 0.01f },
            { FantasySkills.Storytelling, 0.01f },
            { FantasySkills.Puppetry, 0.01f },
            { FantasySkills.Painting, 0f },
            { FantasySkills.Humanities, 0f },
            { FantasySkills.Intrusion, 0.05f },
            { FantasySkills.Investigation, 0.01f },
            { FantasySkills.Medicine, 0.005f },
            { FantasySkills.Meditation, 0f },
            { FantasySkills.Mysticism, 0.008f },
            { FantasySkills.Persuasion, 0.02f },
            { FantasySkills.Psychology, 0.02f },
            { FantasySkills.ScienceAlchemy, .02f },
            { FantasySkills.ScienceMathematics, .01f },
            { FantasySkills.ScienceAstronomy, 0.01f },
            { FantasySkills.ScienceNature, 0f },
            { FantasySkills.ScienceGeology, 0f },
            { FantasySkills.Stealth, 0.02f },
            { FantasySkills.Streetwise, 0.03f },
            { FantasySkills.Survival, 0.003f },
            { FantasySkills.Tactics, 0.01f },
            { FantasySkills.Trickery, 0.04f },
            { FantasySkills.Vehicle, 0f },
            { CombatSkills.Archery, 0.01f },
            { CombatSkills.BladedWeapon, 0.01f },
            { CombatSkills.BluntWeapon, 0.008f },
            { CombatSkills.Crossbows, 0.07f },
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
            FantasyAdvantages.Flexibility,
            FantasyAdvantages.Luck,
        };
        public List<FantasyGameSkill> MandatorySkill { get; set; } = new List<FantasyGameSkill>() 
        {
            FantasySkills.Survival,
        };
    }
}

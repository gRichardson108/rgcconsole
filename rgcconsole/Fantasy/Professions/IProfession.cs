using System;
using System.Collections.Generic;
using System.Text;

namespace rgcconsole.Fantasy.Professions
{
    /// <summary>
    /// A list of weights for the various parts of the profession. Weights are used during generation to randomly distribute points.
    /// Weights are proportional to the point total of a profession.
    /// </summary>
    public interface IProfession
    {
        public string Name { get; set; }
        public Dictionary<AttributeType, float> PrimaryAttributeWeights { get; set; }
        public Dictionary<AttributeType, float> SecondaryAttributeWeights { get; set; }

        public Dictionary<Trait, float> AdvantageWeights { get; set; }
        public Dictionary<Trait, float> DisadvantageWeights { get; set; }

        public Dictionary<FantasyGameSkill, float> SkillWeights { get; set; }
        public Dictionary<FantasyGameSpell, float> SpellWeights { get; set; }
    }
}

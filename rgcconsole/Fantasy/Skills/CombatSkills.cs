using System;
using System.Collections.Generic;
using System.Text;

namespace rgcconsole.Fantasy.Skills
{
    class CombatSkills
    {
        public static FantasyGameSkill Archery = new FantasyGameSkill(AttributeType.DX, FantasyGameSkill.FantasySkillDifficulty.Specialized)
        {
            Name = "Archery",
            Description = "Shooting a bow-and-arrow at a target.",
        };

        public static FantasyGameSkill BladedWeapon = new FantasyGameSkill(AttributeType.DX, FantasyGameSkill.FantasySkillDifficulty.Broad)
        {
            Name = "Bladed Weapons",
            Description = "Various knives, swords, axes, spears, glaives.",
        };

        public static FantasyGameSkill BluntWeapons = new FantasyGameSkill(AttributeType.DX, FantasyGameSkill.FantasySkillDifficulty.Broad)
        {
            Name = "Blunt Weapons",
            Description = "Clubs, flails, morning stars, nunchucks.",
        };

        public static FantasyGameSkill Crossbows = new FantasyGameSkill(AttributeType.DX, FantasyGameSkill.FantasySkillDifficulty.Specialized)
        {
            Name = "Crossbows",
            Description = "Shooting a crossbow",
        };

        public static FantasyGameSkill Firearms = new FantasyGameSkill(AttributeType.DX, FantasyGameSkill.FantasySkillDifficulty.Broad)
        {
            Name = "Firearms",
            Description = "All manner of firearms. Includes maintenance skills.",
        };
        
        public static FantasyGameSkill Shield = new FantasyGameSkill(AttributeType.DX, FantasyGameSkill.FantasySkillDifficulty.Broad)
        {
            Name = "Shield",
            Description = "Blocking with shields, bucklers, etc, slamming with shields. Block skill as a defensive manuever is equal to (shield/2) + 3, rounded down.",
        };

        public static FantasyGameSkill UnarmedStrikes = new FantasyGameSkill(AttributeType.DX, FantasyGameSkill.FantasySkillDifficulty.Specialized)
        {
            Name = "Unarmed Strikes",
            Description = "Training in striking arts, like boxing, or karate. Also improves damage; if you know Unarmed Strikes at DX+0, add +1 damage to unarmed strikes, at DX+1 or more, add +2 damage.",
        };

        public static FantasyGameSkill Wrestling = new FantasyGameSkill(AttributeType.DX, FantasyGameSkill.FantasySkillDifficulty.Specialized)
        {
            Name = "Wrestling",
            Description = "Training in grappling and pinning techniques. Also improves damage; if you know Wrestling at DX+0, add +1 damage to wrestling attacks, at DX+1 or better, add +2 damage. Wrestling attacks include any choke, takedown, neck snap, or limb wrenching style attack.",
        };
    }
}

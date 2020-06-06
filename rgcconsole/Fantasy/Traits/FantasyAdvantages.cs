using System;
using System.Collections.Generic;
using System.Text;

namespace rgcconsole.Fantasy.Traits
{
    class FantasyAdvantages
    {
        public static Trait AbsoluteDirection = new Trait()
        {
            Name = "Absolute Direction",
            Brief = "You always know which way is north, and you can always retrace any path you've followed in the last month.",
            Description = "",
            PointValue = 5
        };

        public static Trait AcuteHearing = new Trait()
        {
            Name = "Acute Hearing",
            Brief = "+1 per for hearing rolls per level",
            Description = "",
            PointValue = 2,
            Leveled = true,
        };

        public static Trait Ambidexterity = new Trait()
        {
            Name = "Ambidexterity",
            Brief = "Ignore -4 for fighting with off hand",
            Description = "",
            PointValue = 5
        };

        public static Trait AnimalEmpathy = new Trait()
        {
            Name = "Animal Empathy",
            Brief = "Read animal motivations with an IQ roll. Can use influence skills on animals.",
            Description = "",
            PointValue = 5
        };

        public static Trait Appearance = new Trait()
        {
            Name = "Appearance",
            Brief = "Your good (or bad) appearance changes how people react at +1/level if they would be attracted to you.",
            Description = "",
            PointValue = 3,
            Leveled = true,
        };

        public static Trait Charisma = new Trait()
        {
            Name = "Charisma",
            Brief = "+1/level to reaction when using influence skills or actively interacting.",
            Description = "",
            PointValue = 5,
            Leveled = true,
        };

        public static Trait CombatReflexes = new Trait()
        {
            Name = "Combat Reflexes",
            Brief = "+1 to active defense skills, fast draw. +2 to fright checks. +6 to IQ rolls for mental stun recovery.",
            Description = "",
            PointValue = 15,
            ApplyToCharacter = ch => ch.Dodge.Bonus += 1.0f,
        };

        public static Trait DangerSense = new Trait()
        {
            Name = "Danger Sense",
            Brief = "GM will roll against perception secretly in situations involving hazard, and hint you on a success.",
            Description = "",
            PointValue = 15,
        };

        public static Trait Empathy = new Trait()
        {
            Name = "Empathy",
            Brief = "Read peoples motivations and truthfulness with an IQ roll.",
            Description = "",
            PointValue = 15,
        };

        public static Trait EnergyReserve = new Trait()
        {
            Name = "Energy Reserve",
            Brief = "You have special FP points that you can only use for magic, which recharge separately no matter what you're doing. 1 per level.",
            Description = "",
            PointValue = 3,
            Leveled = true,
        };

        public static Trait Fearless = new Trait()
        {
            Name = "Fearless",
            Brief = "+1/level to Will for Fright Checks or supernatural fear.",
            Description = "",
            PointValue = 2,
            Leveled = true,
        };

        public static Trait Fit = new Trait()
        {
            Name = "Fit",
            Brief = "+1 to HT for avoiding knockdown, poison, unconsciousness, death. Recover FP twice as fast.",
            Description = "",
            PointValue = 5,
        };

        public static Trait Flexibility = new Trait()
        {
            Name = "Flexibility",
            Brief = "+3 to climbing or escape rolls, including grapples. Negates penalties for working in tight spaces.",
            Description = "",
            PointValue = 5,
        };

        public static Trait HighPainThreshold = new Trait()
        {
            Name = "High Pain Threshold",
            Brief = "Ignore shock penalties for injury. +3 to HT to avoid knockdown, or similar rolls for torture etc.",
            Description = "",
            PointValue = 5,
        };

        public static Trait Luck = new Trait()
        {
            Name = "Luck",
            Brief = "Once per hour of play, reroll a dice roll twice and take best of the three rolls. Can also apply to when you are attacked (take the worst roll).",
            Description = "",
            PointValue = 15,
        };

        public static Trait MagicResistance = new Trait()
        {
            Name = "Magic Resistance",
            Brief = "-1/level penalty to skill of spellcasters when they use a spell on you. Also +1/level to any roll for resisting magic.",
            Description = "",
            PointValue = 2,
            Leveled = true,
        };

        public static Trait PenetratingVoice = new Trait()
        {
            Name = "Penetrating Voice",
            Brief = "+3 to hearing rolls of others when you really want to be heard. +1 when using voice to intimidate.",
            Description = "",
            PointValue = 1,
        };

        public static Trait RapidHealing = new Trait()
        {
            Name = "Rapid Healing",
            Brief = "+5 HT when rolling to recover lost HP or recover from a crippling injury.",
            Description = "",
            PointValue = 5,
        };

        public static Trait Serendipity = new Trait()
        {
            Name = "Serendipity",
            Brief = "Entitles you to one fortuitous-but-plausible coincidence per session. You're free to suggest occurences, but details are up to GM discretion.",
            Description = "",
            PointValue = 15,
        };

        public static Trait Wealth = new Trait()
        {
            Name = "Wealth",
            Brief = "Increases starting wealth by $2000.",
            Description = "",
            PointValue = 15,
        };

        public static Trait Magery0 = new Trait()
        {
            Name = "Magery",
            Brief = "Required for casting wizard spells. GM will roll secretely against perception the first time you see/touch a magic item. Success means you realize it's magical.",
            Description = "",
            PointValue = 5,
        };

        public static Trait AdvancedMagery = new Trait()
        {
            Name = "Magery",
            Brief = "+1/level to IQ for purposes of casting spells or detecting magic.",
            Description = "",
            PointValue = 10,
            Leveled = true,
        };
    }
}

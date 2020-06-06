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
            Brief = "",
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
            Name = "AnimalEmpathy",
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
    }
}

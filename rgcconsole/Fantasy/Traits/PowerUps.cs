using System;
using System.Collections.Generic;
using System.Text;

namespace rgcconsole.Fantasy.Traits
{
    /// <summary>
    /// Power ups are advantages bought with any left-over points
    /// </summary>
    class PowerUps
    {
        public static Trait HigherPurpose = new Trait()
        {
            Name = "Higher Purpose",
            Brief = "You're a zealous foe of Evil! Each level grants +1 on all attack, damage, defense, resistance rolls you make against (choose one): Demons, Undead. One catch - you can't back down from a fight with such creatures!",
            Description = "",
            PointValue = 5,
            Leveled = true,
        };

        public static Trait RestInPieces = new Trait()
        {
            Name = "Rest in Pieces",
            Brief = "Living foes you personally slay cannot return as undead.",
            Description = "",
            PointValue = 1,
        };


        public static Trait ArmorMastery = new Trait()
        {
            Name = "Armor Mastery",
            Brief = "When wearing any armor, raise its DR by 1.",
            Description = "",
            PointValue = 5,
        };


        public static Trait HeroicArcher = new Trait()
        {
            Name = "Heroic Archer",
            Brief = "You can aim and shoot a bow quickly. Roll archery-3 to fast-draw your bow. Can combine with another archery-3 to fast-draw an arrow, allowing you to shoot once per turn (instead of requiring 3 separate turns)",
            Description = "",
            PointValue = 20,
        };

        public static Trait Daredevil = new Trait()
        {
            Name = "Daredevil",
            Brief = "On any turn where you take a real and unnecessary risk, you get +1 on all success rolls. You also reroll any critical failure, taking the second result.",
            Description = "",
            PointValue = 15,
        };

        public static Trait Gizmo = new Trait()
        {
            Name = "Gizmo",
            Brief = "Each level lets you pull out one piece of gear per game session that you might have plausibly found or had. See DF:A p.39.",
            Description = "",
            PointValue = 5,
            Leveled = true,
        };

        public static Trait Catfall = new Trait()
        {
            Name = "Catfall",
            Brief = "Any time you fall, you subtract 5 yards from the fall distance for the purpose of determining damage.",
            Description = "",
            PointValue = 10,
        };

        public static Trait ToughSkin = new Trait()
        {
            Name = "Tough Skin",
            Brief = "You have 1 DR per level. This doesn't cover your eyes.",
            Description = "",
            PointValue = 3,
            Leveled = true,
        };

        public static Trait DiscriminatorySmell = new Trait()
        {
            Name = "Discriminatory Smell",
            Brief = "You can memorize scents by sniffing and making an IQ roll. You'll automatically recognize them thereafter. Also gives +4 to perception for taste/smell purposes.",
            Description = "",
            PointValue = 15,
        };
    }
}

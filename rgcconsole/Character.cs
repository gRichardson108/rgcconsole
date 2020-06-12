using rgcconsole.Fantasy.Professions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rgcconsole
{
    /// <summary>
    /// Meta-information about an attribute, such as its name and cost-per-level
    /// </summary>
    public class AttributeType
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public int CostPerLevel { get; set; }

        public float ChangePerLevel { get; set; } = 1.0f;

        public delegate CharacterAttribute AttributeFetcherMethod(Character character);

        public AttributeFetcherMethod GetCharacterAttribute { get; set; }

        public static AttributeType ST = new AttributeType() { Name = "Strength", Abbreviation = "ST", Description = "", CostPerLevel = 10, GetCharacterAttribute = (c=>c.Strength) };
        public static AttributeType DX = new AttributeType() { Name = "Dexterity", Abbreviation = "DX", Description = "", CostPerLevel = 20, GetCharacterAttribute = (c => c.Dexterity) };
        public static AttributeType IQ = new AttributeType() { Name = "Intelligence", Abbreviation = "IQ", Description = "", CostPerLevel = 20, GetCharacterAttribute = (c => c.Intelligence) };
        public static AttributeType HT = new AttributeType() { Name = "Health", Abbreviation = "HT", Description = "", CostPerLevel = 10, GetCharacterAttribute = (c => c.Health) };
        public static AttributeType HitPoints = new AttributeType() { Name = "Hit Points", Abbreviation = "HP", Description = "", CostPerLevel = 2, GetCharacterAttribute = (c => c.HitPoints) };
        public static AttributeType Will = new AttributeType() { Name = "Will", Abbreviation = "Will", Description = "", CostPerLevel = 5 , GetCharacterAttribute = (c => c.Will) };
        public static AttributeType Perception = new AttributeType() { Name = "Perception", Abbreviation = "Per", Description = "", CostPerLevel = 5, GetCharacterAttribute = (c => c.Perception) };
        public static AttributeType FatiguePoints = new AttributeType() { Name = "Fatigue Points", Abbreviation = "FP", Description = "", CostPerLevel = 3, GetCharacterAttribute = (c => c.FatiguePoints) };
        public static AttributeType BasicSpeed = new AttributeType() { Name = "Basic Speed", Abbreviation = "BS", Description = "", CostPerLevel = 5, ChangePerLevel = 0.25f, GetCharacterAttribute = (c => c.BasicSpeed) };
        public static AttributeType Dodge = new AttributeType() { Name = "Dodge", Abbreviation = "Dodge", Description = "", CostPerLevel = 15, GetCharacterAttribute = (c => c.Dodge) };
        public static AttributeType BasicMove = new AttributeType() { Name = "Basic Move", Abbreviation = "BM", Description = "", CostPerLevel = 5, GetCharacterAttribute = (c => c.BasicMove) };
    }

    public abstract class CharacterAttribute
    {
        public AttributeType AttributeType { get; }

        public event EventHandler ValueChanged;

        private float _value;
        public virtual float Value { 
            get => _value; 
            protected set
            {
                _value = value;
                // notify secondary attributes / skills that value changed
                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// bonus increases to the attribute that don't cost additional points
        /// example: combat reflexes increases Dodge
        /// </summary>
        public virtual float Bonus { get; set; }
        public int PointsSpent { get; private set; }

        /// <summary>
        /// Spends points to increase the Value of the attribute. Outputs the number
        /// of excess points into uselesslySpentPoints.
        /// </summary>
        /// <param name="PointsToSpend">Points to spend improving the attribute</param>
        /// <param name="uselesslySpentPoints">Points that couldn't be spent because they were less than the amount to the next attribute level.</param>
        public void SpendPoints(int pointsToSpend, out int uselesslySpentPoints)
        {
            int levelsBought = pointsToSpend / AttributeType.CostPerLevel;
            uselesslySpentPoints = pointsToSpend % AttributeType.CostPerLevel;
            PointsSpent += (pointsToSpend - uselesslySpentPoints);
            Value += levelsBought * AttributeType.ChangePerLevel;
        }

        public CharacterAttribute(AttributeType attributeType)
        {
            AttributeType = attributeType;
        }
    }

    public class PrimaryAttribute : CharacterAttribute
    {
        public PrimaryAttribute(AttributeType attributeType, float initalValue) : base(attributeType)
        {
            Value = initalValue;
        }
    }

    public class SecondaryAttribute : CharacterAttribute
    {
        public delegate float CalculateFromBaseAttribute(Character character);
        public Character Character { get; set; }

        private CalculateFromBaseAttribute _recalculate;
        public void Recalculate(Character character)
        {
            Value = _recalculate(character);
        }

        public SecondaryAttribute(AttributeType attributeType, CalculateFromBaseAttribute calcMethod) : base(attributeType)
        {
            _recalculate = calcMethod;
        }
    }


    public class Character
    {
        public string Name { get; set; }
        public IProfession Profession { get; set; }
        public string Gender { get; set; }

        [Display(Name="Remaining")]
        public int RemainingPoints { get; set; }

        /// <summary>
        /// Height in inches.
        /// </summary>
        public int Height { get; set; }

        public PrimaryAttribute Strength { get; set; } = new PrimaryAttribute(AttributeType.ST, 10f);
        public PrimaryAttribute Dexterity { get; set; } = new PrimaryAttribute(AttributeType.DX, 10f);
        public PrimaryAttribute Intelligence { get; set; } = new PrimaryAttribute(AttributeType.IQ, 10f);
        public PrimaryAttribute Health { get; set; } = new PrimaryAttribute(AttributeType.HT, 10f);

        public SecondaryAttribute HitPoints { get; set; } = new SecondaryAttribute(AttributeType.HitPoints, ch => ch.Strength.Value);
        public SecondaryAttribute Will { get; set; } = new SecondaryAttribute(AttributeType.Will, ch => ch.Intelligence.Value);
        public SecondaryAttribute Perception { get; set; } = new SecondaryAttribute(AttributeType.Perception, ch => ch.Intelligence.Value);
        public SecondaryAttribute FatiguePoints { get; set; } = new SecondaryAttribute(AttributeType.FatiguePoints, ch => ch.Health.Value);
        public SecondaryAttribute BasicSpeed { get; set; } = new SecondaryAttribute(AttributeType.BasicSpeed, ch => (ch.Health.Value + ch.Dexterity.Value) / 4.0f);
        public SecondaryAttribute Dodge { get; set; } = new SecondaryAttribute(AttributeType.Dodge, ch => (float) Math.Floor(ch.BasicSpeed.Value + 3.0f));
        public SecondaryAttribute BasicMove { get; set; } = new SecondaryAttribute(AttributeType.BasicMove, ch => (float)Math.Floor(ch.BasicSpeed.Value));
        
        public readonly List<PrimaryAttribute> primaryAttributes;
        public readonly List<SecondaryAttribute> secondaryAttributes;

        public Character()
        {
            primaryAttributes = new List<PrimaryAttribute>()
            {
                Strength,
                Dexterity,
                Intelligence,
                Health
            };

            secondaryAttributes = new List<SecondaryAttribute>()
            {
                HitPoints,
                Will,
                Perception,
                FatiguePoints,
                BasicSpeed,
                Dodge,
                BasicMove,
            };
            foreach (SecondaryAttribute attr in secondaryAttributes)
            {
                // update secondaries based on default vals for primaries
                attr.Recalculate(this);
            }
        }

        public List<Trait> Traits { get; } = new List<Trait>();
        public List<Skill> Skills { get; } = new List<Skill>();
    }

    /// <summary>
    /// Advantages and Disadvantages are collectively called "Traits".
    /// </summary>
    public struct Trait
    {
        public string Name { get; set; }

        public string Brief { get; set; }
        public string Description { get; set; }

        public bool Leveled { get; set; }
        public int Level { get; set; }
        public bool HasSelfControlRoll { get; set; }

        public Trait(Trait t)
        {
            Name = t.Name;
            Brief = t.Brief;
            Description = t.Description;
            Leveled = t.Leveled;
            Level = t.Level;
            HasSelfControlRoll = t.HasSelfControlRoll;
            PointValue = t.PointValue;
            ApplyToCharacter = t.ApplyToCharacter;
        }

        /// <summary>
        /// Point cost of the trait. Can be negative for disadvantages.
        /// </summary>
        public int PointValue { get; set; }

        public delegate void Applicator(Character character);
        public Applicator ApplyToCharacter { get; set; }
    }

    public abstract class Skill
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public AttributeType BaseAttribute { get; protected set; }

        /// <summary>
        /// The roll relative to the base attribute of the skill.
        /// </summary>
        public int CurrentSkillLevel { get; set; } = -6; // default for unlearned skill

        public int PointsSpent { get; protected set; } = 0;

        public abstract void SpendPoints(int pointsToSpend, out int uselesslySpentPoints);
    }
}

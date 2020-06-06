using System;
using System.Collections.Generic;
using System.Text;

namespace rgcconsole.Fantasy.Skills
{
    class FantasySkills
    {
        public static FantasyGameSkill Academia = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Academia", 
            Description = "Research techniques and cultural knowledge." 
        };

        public static FantasyGameSkill Acrobatics = new FantasyGameSkill(AttributeType.DX, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Acrobatics", 
            Description = "Climbing, jumping, maintaining balance, etc." 
        };

        public static FantasyGameSkill Administration = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Administration", 
            Description = "Dealing with bureaucracy, financial and legal issues, logistics, etc." 
        };

        public static FantasyGameSkill AnimalHandling = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Animal Handling", 
            Description = "IQ	Work with, train or ride suitable animals. Can specialize for types of animals, such as Horses or Canines." 
        };

        public static FantasyGameSkill Athletics = new FantasyGameSkill(AttributeType.HT, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Athletics", 
            Description = "Swimming, running long distances, playing sports." 
        };

        public static FantasyGameSkill Craft = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Craft", 
            Description = "Make or repair simple items like clothing, hand tools and furniture. Can specialize in Carpentry, Metalworking, Sculpting, etc." 
        };

        public static FantasyGameSkill Engineering = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Engineering", 
            Description = "Build, design or maintain machines and other complex structures (like buildings). Can specialize in Architecture, Mechanical, etc." 
        };

        public static FantasyGameSkill Expression = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Specialized)
        { 
            Name = "Expression", 
            Description = "Any form of art or performance.",
            MustSpecialize = true,
            Specializations = new List<string>
            {
                "Singing",
                "Dancing",
                "Sculpting",
                "Musical Instrument",
                "Storytelling",
                "Puppetry",
                "Painting",
            }
        };

        public static FantasyGameSkill Humanities = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        {
            Name = "Humanities", 
            Description = "Understand complex social structures, like language, economies and governments.",
        };

        public static FantasyGameSkill Intrusion = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Intrusion", 
            Description = "Picking locks, circumventing traps and security systems." 
        };

        public static FantasyGameSkill Investigation = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Investigation", 
            Description = "Spotting important details and asking the right questions." 
        };

        public static FantasyGameSkill Medicine = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Medicine", 
            Description = "Healing techniques and knowledge of drugs." 
        };

        public static FantasyGameSkill Meditation = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Meditation", 
            Description = "Control over your own mental state." 
        };

        public static FantasyGameSkill Mysticism = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Mysticism",
            Description = "Knowledge of religion, magic and the occult." 
        };

        public static FantasyGameSkill Persuasion = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Persuasion", 
            Description = "Negotiate, inspire or browbeat others to do what you want." 
        };

        public static FantasyGameSkill Psychology = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Psychology", 
            Description = "Understanding other people." 
        };

        public static FantasyGameSkill Science = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Specialized)
        { 
            Name = "Science", 
            Description = "Knowledge of physical sciences.",
            MustSpecialize = true,
            Specializations = new List<string>
            {
                "Nature",
                "Mathematics",
                "Geography",
                "Geology",
                "Astronomy",
            }
        };

        public static FantasyGameSkill Stealth = new FantasyGameSkill(AttributeType.DX, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Stealth", 
            Description = "Moving silently and concealment." 
        };

        public static FantasyGameSkill Streetwise = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Streetwise",
            Description = "Knowledge of criminal matters and the underclass." 
        };

        public static FantasyGameSkill Survival = new FantasyGameSkill(AttributeType.Perception, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Survival", 
            Description = "Finding food and shelter in hostile environments." 
        };

        public static FantasyGameSkill Tactics = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Tactics", 
            Description = "Understanding of military matters and warfare." 
        };

        public static FantasyGameSkill Trickery = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Broad)
        { 
            Name = "Trickery", 
            Description = "Confuse, deceive and distract people." 
        };

        public static FantasyGameSkill Vehicle = new FantasyGameSkill(AttributeType.IQ, FantasyGameSkill.FantasySkillDifficulty.Specialized)
        { 
            Name = "Vehicle",
            Description = "Control vehicles.", 
            MustSpecialize = true, 
            Specializations = new List<string>
            {
                "Horse",
                "Boat",
                "Mechanical"
            } 
        };
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace rgcconsole.Fantasy.Traits
{
    class FantasyDisadvantages
    {
        public static Trait AbsentMindedness = new Trait()
        {
            Name = "Absent-Mindedness",
            Brief = "Roll Will-5 to concentrate on boring or repetitive tasks. On failure, you are lost in thought and at -5 to IQ rolls (including perception).",
            Description = "",
            PointValue = -15,
        };

        public static Trait BadTemper = new Trait()
        {
            Name = "Bad Temper",
            Brief = "Make a CR in stressful situations. On failure, lose your temper and insult/attack/act out against the cause of the stress.",
            Description = "",
            PointValue = -10,
            HasSelfControlRoll = true,
        };

        public static Trait Berserk = new Trait()
        {
            Name = "Berserk",
            Brief = "See DF:A p57. When you take injury over HP/4 you must make a CR or go berserk (can only all-out attack). Can attempt CR when you down a foe. You may attack friends if no foes.",
            Description = "",
            PointValue = -10,
            HasSelfControlRoll = true,
        };

        public static Trait Bloodlust = new Trait()
        {
            Name = "Bloodlust",
            Brief = "You want your enemies DEAD. Must make a CR in any situation where you'd accept surrender or avoid delivering a killing blow. Failure means you must try to kill them instead.",
            Description = "",
            PointValue = -10,
            HasSelfControlRoll = true,
        };

        public static Trait Charitable = new Trait()
        {
            Name = "Charitable",
            Brief = "Feel compelled to help others around you, even enemies. Make a CR to avoid rendering aid, even if it means walking into a trap.",
            Description = "",
            PointValue = -15,
            HasSelfControlRoll = true,
        };

        public static Trait Chummy  = new Trait()
        {
            Name = "Chummy",
            Brief = "Unhappy when alone. -1 to IQ skills when unaccompanied.",
            Description = "",
            PointValue = -5,
        };

        public static Trait OutlawHonor = new Trait()
        {
            Name = "Outlaw's Code of Honor",
            Brief = "Principles: Always avenge an insult; your buddy's foe is your own; never attack a buddy except in a fair duel. Anything else goes!",
            Description = "",
            PointValue = -5,
        };

        public static Trait SoldiersHonor = new Trait()
        {
            Name = "Soldier's Code of Honor",
            Brief = "Principles: When leading, lead from the front. Look out for your buddies. Be ready to fight and die for your unit's honor. Treat an honorable enemy with respect.",
            Description = "",
            PointValue = -10,
        };

        public static Trait ChivalryHonor = new Trait()
        {
            Name = "Chivalric Code of Honor",
            Brief = "Principles: Never break your word. Never ignore an insult (must be wiped out by apology or duel). Never take advantage of an opponent, weapons/circumstances must be equal (only applies to \"civilized\" folk. Must protect anyone weaker than yourself.",
            Description = "",
            PointValue = -15,
        };

        public static Trait Curious = new Trait()
        {
            Name = "Curious",
            Brief = "Rash curiousity. Make a CR when presented with an unfamiliar item or button. Failure means you must examine - push buttons, open doors, etc, even if you KNOW it will be dangerous. You must investigate genuine mysteries.",
            PointValue = -5,
            HasSelfControlRoll = true,
        };


        public static Trait Greed = new Trait()
        {
            Name = "Greed",
            Brief = "Rash greed. Make a CR when riches are offered. Failure means you'll do whatever it takes to get the payoff.",
            PointValue = -15,
            HasSelfControlRoll = true,
        };

        public static Trait Illiteracy = new Trait()
        {
            Name = "Illiteracy",
            Brief = "You don't know how to read or write!",
            PointValue = -3,
        };

        public static Trait Klutz = new Trait()
        {
            Name = "Klutz",
            Brief = "GM makes a secret DX roll once per day. Failure means you'll drop, knock over, or stumble into something at an ill-timed moment.",
            PointValue = -5,
        };

        public static Trait NoSenseOfHumor = new Trait()
        {
            Name = "No Sense Of Humor",
            Brief = "You never get jokes, and think everyone is earnestly serious. You never joke, and ARE earnest at all times. -2 reaction in all but the most solemn situations.",
            PointValue = -10,
        };

        public static Trait OdiousPersonalHabit = new Trait()
        {
            Name = "Odious Personal Habit",
            Brief = "You have some kind of annoying habit, bad hygiene, or poor manners that causes most people to react at -1.",
            PointValue = -5,
        };

        public static Trait SenseOfDutyCompanions = new Trait()
        {
            Name = "Sense of Duty (Companions)",
            Brief = "You are unable to betray or abandon your companions. (No CR, the GM simply overrules your attempt!)",
            PointValue = -5,
        };

        public static Trait Truthfulness = new Trait()
        {
            Name = "Truthfulness",
            Brief = "Must make a CR to lie by omission. CR-5 to actually speak a falsehood.",
            PointValue = -5,
            HasSelfControlRoll = true,
        };

        public static Trait Xenophilia = new Trait()
        {
            Name = "Xenophilia",
            Brief = "Fascinated and attracted to strange people and intelligent monsters, however dangerous. Make a CR for sapient creatures who are unlike you. Failure means you'll try to interact socially, even if your companions are trying to fight!",
            PointValue = -10,
            HasSelfControlRoll = true,
        };

    }
}

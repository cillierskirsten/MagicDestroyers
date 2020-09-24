using MagicDestroyers.Enumerations;
using System;

namespace MagicDestroyers
{
    class Consts
    {

        public static string NAME { get; internal set; }

        #region default values
        //MELEE
        //Asssassins
        public static class Assassin
        {
            //private static int msmsm = EndPoint.Next(1,12);

            public const Faction FACTION = Faction.Melee;
            public const string NAME = "John";
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const int LEVEL = 1;
        }
        //Knights
        public static class Knight
        {
            public const Faction FACTION = Faction.Melee;
            public const string NAME = "Annie";
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const int LEVEL = 1;
        }
        //Warrior
        public static class Warrior
        {
            public const Faction FACTION = Faction.Melee;
            public const string NAME = "Josh";
            public const int ABILITY_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const int LEVEL = 1;
        }

        //SPELLCASTERS
        //Druid
        public static class Druid
        {
            public const Faction FACTION = Faction.Spellcasters;
            public const string NAME = "Turtle";
            public const int MAGIC_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const int LEVEL = 1;
        }
        //Mage
        public static class Mage
        {
            public const Faction FACTION = Faction.Spellcasters;
            public const string NAME = "Marns";
            public const int MAGIC_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const int LEVEL = 1;
        }
        //Necromancer
        public static class Necromancer
        {
            public const Faction FACTION = Faction.Spellcasters;
            public const string NAME = "Karien";
            public const int MAGIC_POINTS = 10;
            public const int HEALTH_POINTS = 100;
            public const int LEVEL = 1;
        }

        #endregion default values
    }
}

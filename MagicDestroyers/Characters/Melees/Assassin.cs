using MagicDestroyers.Armors.Leather;
using MagicDestroyers.Enumerations;
using MagicDestroyers.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melees
{
    public class Assassin : Melee
    {
        #region default values
        private readonly LeatherVest BODY_ARMOR = new LeatherVest();
        private readonly Sword WEAPON = new Sword();
        #endregion default values

        #region FIELDS
        #endregion FIELDS

        #region PROPERTIES
        #endregion PROPERTIES

        #region CONSTRUCTORS
        //defaul ctor
        public Assassin()
            //chaining ctors - for this to work first ctor must satisfy signature of second ctor, 2nd ctor must satisfy ctor of 3rd, and so forth
            :this(Consts.Assassin.NAME, Consts.Assassin.LEVEL)
        {
        }
        //name, level ctor
        public Assassin(string name, int level)
            :this(name, level, Consts.Assassin.ABILITY_POINTS)
        {
        }
        //name, level, abilityPoints ctor
        public Assassin(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            base.Faction = Consts.Assassin.FACTION;
            base.HealthPoints = Consts.Assassin.HEALTH_POINTS;

            base.BodyArmor = BODY_ARMOR;
            base.Weapon = WEAPON;

            base.IsAlive = true;
            base.Scores = 0;
        }
        #endregion CONSTRUCTORS

        #region METHODS
        public int Raze()
        {
            return base.Weapon.DamagePoints + 10;
        }
        public override int Attack()
        {
            return this.Raze();
        }

        public int Bleed()
        {
            throw new NotImplementedException();
        }
        public override int SpecialAttack()
        {
            return this.Bleed();
        }

        public int Survival()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }
        public override int Defend()
        {
            return this.Survival();
        }
        #endregion METHODS
    }
}
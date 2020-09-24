using MagicDestroyers.Armors.Leather;
using MagicDestroyers.Enumerations;
using MagicDestroyers.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        #region default values
        private readonly LeatherVest BODY_ARMOR = new LeatherVest();
        private readonly Staff WEAPON = new Staff();
        #endregion default values

        #region FIELDS
        #endregion FIELDS

        #region PROPERTIES
        #endregion PROPERTIES

        #region CONSTRUCTORS
        //default ctor
        public Druid()
            //chaining ctors - for this to work first ctor must satisfy signature of second ctor, 2nd ctor must satisfy ctor of 3rd, and so forth
            : this(Consts.Druid.NAME, Consts.Druid.LEVEL)
        {
        }
        //name, level ctor
        public Druid(string name, int level)
            : this(name, level, Consts.Druid.MAGIC_POINTS)
        {
        }
        //name, level, abilityPoints ctor
        public Druid(string name, int level, int magicPoints)
            : base(name, level, magicPoints)
        {
            base.Faction = Consts.Druid.FACTION;
            base.HealthPoints = Consts.Druid.HEALTH_POINTS;

            base.BodyArmor = BODY_ARMOR;
            base.Weapon = WEAPON;

            base.IsAlive = true;
            base.Scores = 0;
        }
        #endregion CONSTRUCTORS

        #region METHODS
        public int Moonfire()
        {
            return base.Weapon.DamagePoints + 10;
        }
        public override int Attack()
        {
            return this.Moonfire();
        }
        public int Starburst()
        {
            throw new NotImplementedException();
        }
        public override int SpecialAttack()
        {
            return this.Starburst();
        }
        public int OneWithNature()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }
        public override int Defend()
        {
            return this.OneWithNature();
        }
        #endregion METHODS

    }
}
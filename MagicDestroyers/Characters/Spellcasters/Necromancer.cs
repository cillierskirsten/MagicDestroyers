using MagicDestroyers.Armors.Leather;
using MagicDestroyers.Weapons.Sharp;
using System.Configuration;
using System;
using MagicDestroyers.Enumerations;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        #region default values
        private readonly LeatherVest BODY_ARMOR = new LeatherVest();
        private readonly Sword WEAPON = new Sword();
        #endregion default values

        #region FIELDS
        #endregion FIELDS

        #region PROPERTIES
        #endregion PROPERTIES

        #region CONSTRUCTOR
        //default ctor
        public Necromancer()
            //chaining ctors - for this to work first ctor must satisfy signature of second ctor, 2nd ctor must satisfy ctor of 3rd, and so forth
            : this(Consts.Necromancer.NAME, Consts.Necromancer.LEVEL)
        {
        }
        //name, level ctor
        public Necromancer(string name, int level)
            : this(name, level, Consts.Necromancer.MAGIC_POINTS)
        {
        }
        //name, level, abilityPoints ctor
        public Necromancer(string name, int level, int magicPoints)
            : base(name, level, magicPoints)
        {
            base.Faction = Consts.Necromancer.FACTION;
            base.HealthPoints = Consts.Necromancer.HEALTH_POINTS;

            base.BodyArmor = BODY_ARMOR;
            base.Weapon = WEAPON;

            base.IsAlive = true;
            base.Scores = 0;
        }
        #endregion CONSTRUCTOR

        #region METHODS
        public int ShadowRage()
        {
            return base.Weapon.DamagePoints + 10;
        }
        public override int Attack()
        {
            return this.ShadowRage();
        }
        public int VampireTouch()
        {
            throw new NotImplementedException();
        }
        public override int SpecialAttack()
        {
            return this.VampireTouch();
        }
        public int BoneShiled()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }
        public override int Defend()
        {
            return this.BoneShiled();
        }
        #endregion METHODS
    }
}
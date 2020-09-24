using MagicDestroyers.Armors.Mail;
using MagicDestroyers.Enumerations;
using MagicDestroyers.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Melees
{
    public class Knight : Melee
    {
        #region default values
        private readonly Chainlink BODY_ARMOR = new Chainlink();
        private readonly Hammer WEAPON = new Hammer();
        #endregion default values

        #region FIELDS
        #endregion FIELDS

        #region PROPERTIES
        #endregion PROPERTIES

        #region CONSTRUCTOR
        //defaul ctor
        public Knight()
            //chaining ctors - for this to work first ctor must satisfy signature of second ctor, 2nd ctor must satisfy ctor of 3rd, and so forth
            : this(Consts.Knight.NAME, Consts.Knight.LEVEL)
        {
        }
        //name, level ctor
        public Knight(string name, int level)
            : this(name, level, Consts.Knight.ABILITY_POINTS)
        {
        }
        //name, level, abilityPoints ctor
        public Knight(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            base.Faction = Consts.Knight.FACTION;
            base.HealthPoints = Consts.Knight.HEALTH_POINTS;

            base.BodyArmor = BODY_ARMOR;
            base.Weapon = WEAPON;

            base.IsAlive = true;
            base.Scores = 0;
        }
        #endregion CONSTRUCTOR

        #region METHODS
        public int HolyBlow()
        {
            return base.Weapon.DamagePoints + 10;
        }
        public override int Attack()
        {
            return this.HolyBlow();
        }
        public int PurifySoul()
        {
            throw new NotImplementedException();
        }
        public override int SpecialAttack()
        {
            return this.PurifySoul();
        }
        public int RighteousWings()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }
        public override int Defend()
        {
            return this.RighteousWings();
        }
        #endregion METHODS
    }
}
using MagicDestroyers.Armors.Cloth;
using MagicDestroyers.Enumerations;
using MagicDestroyers.Weapons.Blunt;
using System;
using System.CodeDom;
using System.Security.Cryptography.X509Certificates;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        #region default values
        private readonly ClothRobe BODY_ARMOR = new ClothRobe();
        private readonly Staff WEAPON = new Staff();
        #endregion default values

        #region FIELDS
        #endregion FIELDS

        #region PROPERTIES
        #endregion PROPERTIES

        #region CONSTRUCTORS
        //default ctor
        public Mage()
            //chaining ctors - for this to work first ctor must satisfy signature of second ctor, 2nd ctor must satisfy ctor of 3rd, and so forth
            : this(Consts.Mage.NAME, Consts.Mage.LEVEL)
        {
        }
        //name, level ctor
        public Mage(string name, int level)
            : this(name, level, Consts.Mage.MAGIC_POINTS)
        {
        }
        //name, level, abilityPoints ctor
        public Mage(string name, int level, int magicPoints)
            : base(name, level, magicPoints)
        {
            base.Faction = Consts.Mage.FACTION;
            base.HealthPoints = Consts.Mage.HEALTH_POINTS;

            base.BodyArmor = BODY_ARMOR;
            base.Weapon = WEAPON;

            base.IsAlive = true;
            base.Scores = 0;
        }
        #endregion CONSTRUCTORS

        #region METHODS
        public int ArcaneWrath()
        {
            return base.Weapon.DamagePoints + 10;
        }
        public override int Attack()
        {
            return this.ArcaneWrath();
        }
        public int Firewall()
        {
            throw new NotImplementedException();
        }
        public override int SpecialAttack()
        {
            return this.Firewall();
        }
        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }
        public override int Defend()
        {
            return this.Meditation();
        }
        #endregion METHODS
    }
}
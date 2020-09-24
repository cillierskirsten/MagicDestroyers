using MagicDestroyers.Armors.Mail;
using MagicDestroyers.Enumerations;
using MagicDestroyers.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melees
{
    public class Warrior : Melee
    {
        #region default values
        private readonly Chainlink BODY_ARMOR = new Chainlink();
        private readonly Axe WEAPON = new Axe();
        #endregion default values

        #region FIELDS
        #endregion FIELDS

        #region PROPERTIES
        #endregion PROPERTIES

        #region CONSTRUCTOR
        //defaul ctor
        public Warrior()
            //chaining ctors - for this to work first ctor must satisfy signature of second ctor, 2nd ctor must satisfy ctor of 3rd, and so forth
            : this(Consts.Warrior.NAME, Consts.Warrior.LEVEL)
        {
        }
        //name, level ctor
        public Warrior(string name, int level)
            : this(name, level, Consts.Warrior.ABILITY_POINTS)
        {
        }
        //name, level, abilityPoints ctor
        public Warrior(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            base.Faction = Consts.Warrior.FACTION;
            base.HealthPoints = Consts.Warrior.HEALTH_POINTS;

            base.BodyArmor = BODY_ARMOR;
            base.Weapon = WEAPON;

            base.IsAlive = true;
            base.Scores = 0;
        }

        public override void Move(double speed)
        {
            speed *= 1.2;
            base.Move(speed);
        }
        #endregion CONSTRUCTOR

        #region METHODS
        public int Strike()
        {
            return base.Weapon.DamagePoints + 10;
        }
        public override int Attack()
        {
            return this.Strike();
        }
        public int Execute()
        {
            throw new NotImplementedException();
        }
        public override int SpecialAttack()
        {
            return this.Execute();
        }
        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }
        public override int Defend()
        {
            return this.SkinHarden();
        }
        #endregion METHODS
    }
}
namespace MagicDestroyers.Characters
{
    using MagicDestroyers.Armors;
    using MagicDestroyers.Characters.Interfaces;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons;
    using System;
    using System.CodeDom;
    using System.Threading;

    public abstract class Character : IAttack, IDefend
    {
        #region FIELDS
        private Faction faction;
        private Weapon weapon;
        private Armor bodyArmor;
        
        private string name;

        private int healthPoints;
        private int level;
        private int scores;

        private bool isAlive;
        #endregion FIELDS

        #region PROPERTIES
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }
        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }
        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 2 || value.Length <= 10)
                {
                    this.name = value;
                }
                else if (value.Length < 2)
                {
                    Console.WriteLine("Your name is to short, it should contain a minimum of 2 characters.");
                }
                else if (value.Length > 10)
                {
                    Console.WriteLine("Your name is too long, it should contain a max of 10 characters.");
                }
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 || value <= 120)
                {
                    this.healthPoints = value;
                }
                else
                {
                    this.healthPoints = 0;
                    Console.WriteLine("Inappropriate value! Your value needs to be between 0 and 120.");
                }
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 0 || value <= 100)
                {
                    this.level = value;
                }
                else
                {
                    this.level = 1;
                    Console.WriteLine("Inappropriate value! Your value needs to be between 0 and 100.");
                }
            }
        }
        public int Scores
        {
            get
            {
                return this.scores;
            }
            set
            {
                this.scores = value;
            }
        }

        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }
        #endregion PROPERTIES

        #region CONSTRUCTOR
        //default ctor
        public Character()
        {

        }

        //ctor name & level
        public Character(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }
        public virtual void Move(double speed)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(Convert.ToInt32(speed));
            }
        }

        //public void Attack();
        //{
        //    throw new NotImplementedException();
        //}
        public abstract int Attack();

        //public void SpecialAttack()
        //{
        //    throw new NotImplementedException();
        //}
        public abstract int SpecialAttack();

        //public void Defend()
        //{
        //    throw new NotImplementedException();
        //}
        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName, string type)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();

                if (this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                Tools.ColorfulWriteLine("Mwahahaha, your puny weapons can not penitrate my armor. Better luck next time tiny human!", ConsoleColor.Green);
            }
            if (!isAlive)
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage}% damage from {attackerName}, and unfortunately has perished. RIP {this.name}!!!", type);
            }
            else
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage}% damage from {attackerName}. We will live to fight another day and now have {this.healthPoints}% health left!", type);
            }
        }
        public void WonBattle()
        {
            this.scores++;

            if (this.scores % 10 == 0)
            {
                this.level++;
            }
        }
        #endregion CONSTRUCTOR
    }
}

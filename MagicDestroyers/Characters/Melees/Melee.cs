namespace MagicDestroyers.Characters.Melees
{
    using System;
    public abstract class Melee : Character
    {
        #region FIELDS
        private int abilityPoints;
        #endregion FIELDS

        #region PROPERTIES
        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {

                if (value >= 0 || value <= 10)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    this.abilityPoints = 0;
                    Console.WriteLine("Inappropriate value! Your value needs to be between 0 and 10.");
                }
            }
        }
        #endregion PROPERTIES

        #region CONSTRUCTOR
        //chain ctor
        //name, level, abilityPoints ctor
        public Melee(string name, int level, int abilityPoints)
            : base(name, level)
        {
            this.AbilityPoints = abilityPoints;
        }
        #endregion CONSTRUCTOR
    }
}

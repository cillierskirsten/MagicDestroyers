namespace MagicDestroyers.Characters.Spellcasters
{
    using System;
    public abstract class Spellcaster : Character
    {
        #region FIELDS
        private int magicPoints;
        #endregion FIELDS

        #region PROPERTIES
        public int MagicPoints
        {
            get
            {
                return this.magicPoints;
            }
            set
            {

                if (value >= 0 || value <= 20)
                {
                    this.magicPoints = value;
                }
                else
                {
                    this.magicPoints = 0;
                    Console.WriteLine("Inappropriate value! Your value needs to be between 0 and 10.");
                }
            }
        }
        #endregion PROPERTIES

        #region CONSTRUCTOR
        //chain ctor
        //name, level, magicPoints ctor
        public Spellcaster(string name, int level, int magicPoints)
            : base(name, level)
        {
            this.MagicPoints = magicPoints;
        }
        #endregion CONSTRUCTOR
    }
}

namespace MagicDestroyers.Weapons
{
    using System;
    public abstract class Weapon
    {
        #region FIELDS
        Random rand = new Random();
        private int damagePoints;

        

        #endregion FIELDS

        #region PROPERTIES
        public int DamagePoints
        {
            get
            {
                this.DamagePoints = rand.Next(1, 12);
                return this.damagePoints;
            }
            set
            {
                if (value >= 0 || value <= 100)
                {
                    this.damagePoints = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate value! Your value needs to be between 0 and 100.");
                }
            }
        }

        #endregion PROPERTIES

    }
}

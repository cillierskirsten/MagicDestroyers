namespace MagicDestroyers.Armors
{
    using System;
    public abstract class Armor
    {
        #region FIELDS
        Random rands = new Random();
        private int armorPoints;
        #endregion FIELDS

        #region PROPERTIES
        public int ArmorPoints
        {
            get
            {
                this.armorPoints = rands.Next(1, 12);
                return this.armorPoints;
            }
            set
            {
                if (value >= 0 || value <= 100)
                {
                    this.armorPoints = value;
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

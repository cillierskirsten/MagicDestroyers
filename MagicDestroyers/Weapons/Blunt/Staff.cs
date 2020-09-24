namespace MagicDestroyers.Weapons.Blunt
{
    using System;
    public class Staff : Blunt
    {
        private Weapon weapon;

        Random rand = new Random();
        int damagePoints = 10;

        public int DamagePoints
        {
            get
            {
                damagePoints = rand.Next(1, 12);
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

        #region CONSTRUCTOR
        public Staff()
        {
        }
        public Staff(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }
        #endregion CONSTRUCTOR

        #region METHODS
        public void Empower()
        {
            throw new NotImplementedException();
        }
        #endregion METHODS
    }
}
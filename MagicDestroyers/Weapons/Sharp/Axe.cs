namespace MagicDestroyers.Weapons.Sharp
{
    using System;
    public class Axe : Sharp
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

        #region CONSTRUCTORS
        public Axe()
        {
        }
        public Axe(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }
        #endregion CONSTRUCTORS

        #region METHODS    
        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
        #endregion METHODS   
    }
}
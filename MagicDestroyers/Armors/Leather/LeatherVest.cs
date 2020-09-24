namespace MagicDestroyers.Armors.Leather
{
    using System;
    public class LeatherVest : Armor
    {

        Random rand = new Random();
        int armorPoints = 10;

        public int ArmorPoints
        {
            get
            {
                armorPoints = rand.Next(1, 12);
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
        #region CONSTRUCTOR
        public LeatherVest()
            : base()
        {

        }
        public LeatherVest(int damagePoints)
        {
            this.ArmorPoints = damagePoints;
        }
        #endregion CONSTRUCTOR
    }
}
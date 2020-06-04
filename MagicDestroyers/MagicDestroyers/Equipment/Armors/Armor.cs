using System;

namespace MagicDestroyers.Equipment.Armors
{
    public class Armor
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return this.armorPoints;
            }
            set
            {
                if (value >= 1)
                {
                    this.armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The armor points should be greater than 1.");
                }
            }
        }
    }
}

using System;

namespace MagicDestroyers.Equipment.Weapons
{
    public abstract class Weapon
    {
        private int damagePoints;

        public int DamagePoints
        {
            get
            {
                return this.damagePoints;
            }
            set
            {
                if (value >= 1)
                {
                    this.damagePoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The damage should be greater than 1.");
                }
            }
        }        
    }
}

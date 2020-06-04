using System;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe : Sharp
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Axe()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Axe(int damage)
        {
            this.DamagePoints = damage;
        }
                
        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
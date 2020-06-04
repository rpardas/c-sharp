using System;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword : Sharp
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Sword()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Sword(int damage)
        {
            this.DamagePoints = damage;
        }
        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }

    }
}
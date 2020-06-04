using System;
using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {        
        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();


        public Mage()
            : this(Consts.Mage.NAME, 1)
        {

        }

        public Mage(string name, int level)
            : this(name, level, Consts.Mage.HEALTH_POINTS)
        {

        }

        public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.ManaPoints = Consts.Mage.MANA_POINTS;
            base.Faction = Faction.Spellcaster;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public int Firewall()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Firewall();
        }

        public override int Defend()
        {
            return this.Meditation();
        }

        public override int SpecialAttack()
        {
            return this.ArcaneWrath();
        }
    }
}
using Coliseum.Interfaces;
using Coliseum.Models.Catalogs.DamageTypes;
using Coliseum.Utils.Extentions;

namespace Coliseum.Models.Bases.Damage
{
    public abstract class BaseDamage : IDamage
    {
        private readonly double SpreadPercentage = 0.2;

        public abstract DamageTypeCatalog DamageType { get; set; }

        protected abstract int Damage { get; set; }

        public int GetDamageValue()
        {
            return _getDamage();
        }

        private int _getDamage()
        {
            if (DamageType.Id == DamageTypeHolder.ClearDamage.Id)
            {
                return Damage;
            }

            var minDamage = (int)(Damage * (1 - SpreadPercentage));
            var maxDamage = (int)(Damage * (1 + SpreadPercentage));
            var damage = RandomExtensions.GenerateRandomNumber(minDamage, maxDamage);

            return damage;
        }
    }
}

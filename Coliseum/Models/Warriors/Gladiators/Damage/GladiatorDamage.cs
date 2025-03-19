using Coliseum.Models.Bases.Damage;
using Coliseum.Models.Catalogs.DamageTypes;

namespace Coliseum.Models.Warriors.Gladiator
{
    public class GladiatorDamage : BaseDamage
    {
        public GladiatorDamage()
        {
            DamageType = DamageTypeHolder.PhysicalDamage;
            Damage = 60;
        }

        public override DamageTypeCatalog DamageType { get; set; }

        protected override int Damage { get; set; }
    }
}

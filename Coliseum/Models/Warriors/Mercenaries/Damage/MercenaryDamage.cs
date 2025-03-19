using Coliseum.Models.Bases.Damage;
using Coliseum.Models.Catalogs.DamageTypes;

namespace Coliseum.Models.Warriors.Mercenary
{
    public class MercenaryDamage : BaseDamage
    {
        public MercenaryDamage() {
            DamageType = DamageTypeHolder.PhysicalDamage;
            Damage = 40;
        }
        public override DamageTypeCatalog DamageType { get; set; }

        protected override int Damage { get; set; }
    }
}

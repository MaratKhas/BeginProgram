using Coliseum.Models.Bases.Damage;
using Coliseum.Models.Catalogs.DamageTypes;

namespace Coliseum.Models.Warriors.Slave
{
    public class SlaveDamage : BaseDamage
    {
        public SlaveDamage() {
            DamageType = DamageTypeHolder.PhysicalDamage;
            Damage = 20;
        }
        public override DamageTypeCatalog DamageType { get; set; }

        protected override int Damage { get; set; }
    }
}

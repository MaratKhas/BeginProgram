using Coliseum.Models.Catalogs.DamageTypes;

namespace Coliseum.Interfaces
{
    public interface IDamage
    {
        DamageTypeCatalog DamageType { get; }

        int GetDamageValue();
    }
}

namespace Coliseum.Models.Catalogs.DamageTypes
{
    public static class DamageTypeHolder
    {
        /// <summary>
        /// Физическая атака
        /// </summary>
        public static DamageTypeCatalog PhysicalDamage => new DamageTypeCatalog(1, "Физический");

        /// <summary>
        /// Магическая атака
        /// </summary>
        public static DamageTypeCatalog MagicDamage = new DamageTypeCatalog(2, "Магический");

        /// <summary>
        /// Атака с чистым уроном
        /// </summary>
        public static DamageTypeCatalog ClearDamage => new DamageTypeCatalog(3, "Чистый");
    }
}

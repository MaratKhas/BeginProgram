using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum.Models.Catalogs.DamageTypes
{
    /// <summary>
    /// Класс типов атак
    /// </summary>
    public class DamageTypeCatalog
    {
        public DamageTypeCatalog(short id, string name)
        {
            Id = id;
            Name = name;
        }

        public short Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

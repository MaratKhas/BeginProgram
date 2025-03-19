using Coliseum.Models.Bases;
using Coliseum.Models.Warriors.Gladiator;
using Coliseum.Models.Warriors.Mercenary;
using Coliseum.Models.Warriors.Slave;
using System.Collections.Generic;

namespace Coliseum.Models.Catalogs.Warriors
{
    public static class WarriorHolder
    {
        public static List<BaseWarrior> GetWarriors()
        {
            return new List<BaseWarrior>() {
                Slave,
                Mercenaries,
                Gladiator,
            };
        }

        private static readonly BaseWarrior Slave = new Slave();

        private static readonly BaseWarrior Mercenaries = new Mercenary();

        private static readonly BaseWarrior Gladiator = new Gladiator();


    }
}

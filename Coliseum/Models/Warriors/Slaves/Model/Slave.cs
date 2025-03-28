using Coliseum.Interfaces;
using Coliseum.Models.Bases;

namespace Coliseum.Models.Warriors.Slave
{
    public class Slave : BaseWarrior
    {
        public Slave() {
            Damage = new SlaveDamage();
            NameNumber = _cloneIterator;
        }

        protected override string Name => "Раб";

        protected override int MaxHealth => 100;

        protected override IDamage Damage { get; set; }

        protected override int PhysicalDefense => 0;

        protected override int MagicalDefense => 0;

        #region IClonable
        private static int _cloneIterator = 0;

        public override object Clone()
        {
            ++_cloneIterator;
            return new Slave();
        }

        ~Slave()
        {
            --_cloneIterator;
        }
        #endregion
    }
}

using Coliseum.Interfaces;
using Coliseum.Models.Bases;

namespace Coliseum.Models.Warriors.Mercenary
{
    public class Mercenary : BaseWarrior
    {
        public Mercenary()
        {
            Damage = new MercenaryDamage();
            NameNumber = _cloneIterator;
        }

        protected override string Name => "Наемник";

        protected override IDamage Damage { get; set; }

        protected override int PhysicalDefense => 6;

        protected override int MagicalDefense => 0;

        protected override int MaxHealth => 200;


        #region IClonable
        private static int _cloneIterator = 0;

        public override object Clone()
        {
            ++_cloneIterator;
            return new Mercenary();
        }

        ~Mercenary()
        {
            --_cloneIterator;
        }
        #endregion
    }
}

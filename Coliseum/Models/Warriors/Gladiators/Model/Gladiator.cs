using Coliseum.Interfaces;
using Coliseum.Models.Bases;
using Coliseum.Models.Warriors.Gladiators.Ultimate;
using System;

namespace Coliseum.Models.Warriors.Gladiator
{
    public class Gladiator : BaseWarrior, IHaveUltimate<GladiatorUltimate>
    {
        public Gladiator()
        {
            Damage = new GladiatorDamage();
            Ultimate = new GladiatorUltimate();
            NameNumber = _cloneIterator;
        }

        #region BaseWarrior

        protected override string Name => $"Гладиатор";

        protected override int MaxHealth => 400;

        protected override IDamage Damage { get; set; }

        protected override int PhysicalDefense => 15;

        protected override int MagicalDefense => 5;
        #endregion

        #region IClonable
        private static int _cloneIterator = 0;

        public override object Clone()
        {
            ++_cloneIterator;
            return new Gladiator();
        }

        ~Gladiator()
        {
            --_cloneIterator;
        }
        #endregion

        #region IHaveUltimate
        public GladiatorUltimate Ultimate { get; }

        public void UseUltimate()
        {
            var currentHealth = GetHealth();
            if (currentHealth <= MaxHealth / 2 && !Ultimate.IsAlreadyUsing)
            {
                Console.WriteLine($"{Name} использует {Ultimate.GetUltimateDescription()}");
                var heal = (int)(MaxHealth * Ultimate.HpRecoveryPart);
                HealWarrior(heal);
                Ultimate.IsAlreadyUsing = true;
            }
        }
        #endregion
    }
}

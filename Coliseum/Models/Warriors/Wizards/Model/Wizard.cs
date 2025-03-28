using Coliseum.Interfaces;
using Coliseum.Models.Bases;

namespace Coliseum.Models.Warriors.Wizards.Model
{
    public class Wizard : BaseWarrior
    {
        public Wizard()
        {

        }

        protected override string Name => "Маг";

        protected override int MaxHealth => 200;

        protected override IDamage Damage { get; set; }

        protected override int PhysicalDefense => 0;

        protected override int MagicalDefense => 90;

        #region

        public override object Clone()
        {
           return new Wizard();
        }

        #endregion
    }
}

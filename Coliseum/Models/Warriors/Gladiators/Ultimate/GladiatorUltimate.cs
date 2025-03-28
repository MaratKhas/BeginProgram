using Coliseum.Interfaces;

namespace Coliseum.Models.Warriors.Gladiators.Ultimate
{
    public class GladiatorUltimate : IUltimate
    {
        public string Name => "Берсерк";

        public string GetUltimateDescription()
        {
            return "впадает в ярость когда остается меньше половины хп и восстанавливает 20% здоровья";
        }

        public double HpRecoveryPart => 0.2;

        public bool IsAlreadyUsing { get; set; }
    }
}

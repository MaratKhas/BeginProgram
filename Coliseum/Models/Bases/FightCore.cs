using Coliseum.Interfaces;

namespace Coliseum.Models.Bases
{
    public class FightCore
    {
        protected readonly IColiseum _coliseum;

        // сюда мб накинуть логер который будет собирать че произошло

        public FightCore(IColiseum coliseum) {
            _coliseum = coliseum;
        }

        public void StartFight()
        {
            _coliseum.StartFaith();
        }
    }
}

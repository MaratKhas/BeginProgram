using Coliseum.Interfaces;
using Coliseum.Models.Bases;
using Coliseum.Models.WarriorsSelector;
using System;

namespace Coliseum.Models
{
    public class OneToOneColiseum : IColiseum
    {
        private readonly BaseWarrior LeftWarrior;

        private readonly BaseWarrior RightWarrior;

        public OneToOneColiseum() {
            HelloMessage();
            LeftWarrior = WarriorSelector.StartSelect();
            RightWarrior = WarriorSelector.StartSelect();
        }

        private void HelloMessage()
        {
            Console.WriteLine("Добро пожаловать в Колизей битва один на один ");
        }

        public void StartFaith()
        {
            while (LeftWarrior.IsAlive && RightWarrior.IsAlive)
            {
                Console.WriteLine("Атака левой стороны");
                LeftWarrior.Attack(RightWarrior);

                if (RightWarrior.IsAlive)
                {
                    Console.WriteLine("Атака правой стороны");
                    RightWarrior.Attack(LeftWarrior);
                }
            }

            if (LeftWarrior.IsAlive)
                LeftWarrior.VictoryMessage();
            else
                RightWarrior.VictoryMessage();
        }
    }
}

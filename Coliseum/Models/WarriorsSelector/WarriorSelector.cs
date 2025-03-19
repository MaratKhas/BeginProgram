using Coliseum.Models.Bases;
using Coliseum.Models.Catalogs.Warriors;
using System;

namespace Coliseum.Models.WarriorsSelector
{
    public static class WarriorSelector
    {
        public static BaseWarrior StartSelect()
        {        
            Console.WriteLine("Пожалуйста выберите бойца из предложенного списка, нужно ввести порядковый номер бойца");

            BaseWarrior result = null;
            var warriors = WarriorHolder.GetWarriors();

            var index = 0;
            foreach (var warrior in warriors)
            {
                var warriorInfo = warrior.GetWarriorInfo();
                Console.WriteLine($"{index++} - {warriorInfo}");
            }

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out var selectedIndex))
                {
                    if (selectedIndex >= warriors.Count || selectedIndex < 0)
                    {
                        Console.WriteLine("Пожалуйста введите номер из предложенного списка");
                        continue;
                    }
                    result = warriors[selectedIndex].Clone() as BaseWarrior;
                    break;
                }
                else
                    Console.WriteLine("Пожалуйста введите корректный номер");
            }

            return result;
        }
    }
}

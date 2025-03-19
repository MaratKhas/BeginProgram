using Coliseum.Interfaces;
using System;

namespace Coliseum.Models.Bases
{
    /// <summary>
    /// Базовый класс бойца 
    /// </summary>
    public abstract class BaseWarrior : ICanAttack, IDamageable, ICloneable
    {
        protected BaseWarrior()
        {
            _health = MaxHealth;
        }

        #region Abstract Methods
        /// <summary>
        /// Имя бойца 
        /// </summary>
        protected abstract string Name { get; }

        /// <summary>
        /// Максимальное количество хп, используется при инициализации
        /// </summary>
        protected abstract int MaxHealth { get; }

        /// <summary>
        /// Атака бойца
        /// </summary>
        protected abstract IDamage Damage { get; set; }

        /// <summary>
        /// Защита от физических атак
        /// </summary>
        protected abstract int PhysicalDefense { get; }

        /// <summary>
        /// Защита от магических атак
        /// </summary>
        protected abstract int MagicalDefense { get; }

        /// <summary>
        /// При реализации данного метода следует создать статическую переменную которая будет отвечать за количество созданных экземпляров бойцов
        /// </summary>
        /// <returns></returns>
        public abstract object Clone();
        #endregion

        /// <summary>
        /// проставляется в конструкторе каждого отдельного бойца чтобы при выборе одинаковых бойцов как-то их различать
        /// </summary>
        protected int NameNumber { get; set; }

        /// <summary>
        /// Имя с номером, используется в логах хода битвы
        /// </summary>
        private string NameWithNumber => $"{Name}{NameNumber}";

        /// <summary>
        /// Текущее ХП бойца
        /// </summary>
        private int _health;

        /// <summary>
        /// Доступ к текущим ХП
        /// </summary>
        /// <returns></returns>
        public int GetHealth()
        {
            return _health;
        }

        /// <summary>
        /// Свойство жив ли боец
        /// </summary>
        public bool IsAlive => _health > 0;

        /// <summary>
        /// лечит бойца на определенное количество HP
        /// </summary>
        /// <param name="heal">количество HP</param>
        protected void HealWarrior(int heal)
        {
            var healing = Math.Min(heal, MaxHealth);
            Console.WriteLine($"Боец {NameWithNumber} лечит себя на {healing}");
            _health += healing;
        }


        /// <summary>
        /// Атака оппонента
        /// так же на этом шаге используется ультимативная способность если она есть у бойца
        /// </summary>
        /// <param name="opponent"></param>
        public void Attack(IDamageable opponent)
        {
            if (IsAlive)
            {
                Console.WriteLine($"Боец {NameWithNumber} совершает атаку");
                opponent.GetDamage(Damage);

                if (this is IHaveUltimate ultimate)
                {
                    ultimate.UseUltimate();
                }
            }
        }

        /// <summary>
        /// Принятие атаки 
        /// </summary>
        /// <param name="damage"></param>
        /// <exception cref="Exception"></exception>
        public void GetDamage(IDamage damage)
        {
            var damageTypeString = damage.DamageType.ToString();
            var damageValue = damage.GetDamageValue();

            switch (damage.DamageType.Id)
            {
                case 1:
                    _health -= damageValue - PhysicalDefense;
                    Console.WriteLine($"Бойцу {NameWithNumber} нанесено {damage.DamageType.ToString()} урон {damageValue}, заблокировано {PhysicalDefense}");
                    break;
                case 2:
                    _health -= damageValue - MagicalDefense;
                    Console.WriteLine($"Бойцу {NameWithNumber} нанесено {damage.DamageType.ToString()} урон {damageValue}, заблокировано {MagicalDefense}");
                    break;
                case 3:
                    _health -= damageValue;
                    Console.WriteLine($"Бойцу {NameWithNumber} нанесено {damage.DamageType.ToString()} урон {damageValue}");
                    break;

                default:
                    throw new Exception("Данный тип демеджа не существует в системе, пожалуйста ознакомьтесь с файлом DamageTypeHolder.cs");
            }

            Console.WriteLine($"Текущие hp бойца {NameWithNumber} : {_health}");
        }

        /// <summary>
        ///  Сообщение о победе
        /// </summary>
        public void VictoryMessage()
        {
            Console.WriteLine($"Боец {NameWithNumber} победил");
        }

        /// <summary>
        /// Получение информации о бойце
        /// </summary>
        /// <returns></returns>
        public string GetWarriorInfo()
        {
            return $"{Name}, количество hp {MaxHealth} физ резист {PhysicalDefense} маг резист {MagicalDefense}";
        }  
    }
}

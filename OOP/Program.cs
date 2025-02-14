using OOP.Interfaces;
using OOP.Models;
using System;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество карт");
            short.TryParse(Console.ReadLine(), out var countCards);

            IPlayer player = new Player();

            IСroupier croupier = new Croupier(player);

            croupier.GiveCardsToPlayer(countCards);

            Console.WriteLine(player.GetCardsInfo());
            Console.ReadKey();
        }
    }
}

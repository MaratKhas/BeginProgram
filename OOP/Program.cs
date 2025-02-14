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

            var player = new Player();

            var croupier = new Croupier(player);

            croupier.GiveCardsToPlayer(countCards);

            Console.WriteLine(player.GetCardsInfo());
            Console.ReadKey();
        }
    }
}

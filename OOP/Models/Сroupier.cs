using OOP.Interfaces;
using System.Collections.Generic;

namespace OOP.Models
{
    public class Croupier : IСroupier
    {
        public Croupier (IPlayer player)
        {
            Player = player;
        }

        public IDesk Desk { get; private set; } = new Desk();

        public IPlayer Player { get; private set; }

        public void GiveCardsToPlayer(short cardCount)
        {
            ICollection<ICard> cards = Desk.GetCardsFromDesc(cardCount);
            Player.SetCardsToPlayer(cards);
        }
    }
}

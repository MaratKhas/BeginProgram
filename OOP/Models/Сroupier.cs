using System.Collections.Generic;

namespace OOP.Models
{
    public class Croupier
    {
        public Croupier (Player player)
        {
            Player = player;
        }

        private Desk Desk { get; set; } = new Desk ();

        private Player Player { get; set; }

        public void GiveCardsToPlayer(short cardCount)
        {
            List<Card> cards = Desk.GetCardsFromDesc(cardCount);
            Player.SetCardsToPlayer(cards);
        }
    }
}

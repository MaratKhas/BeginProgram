namespace OOP.Models
{
    public class Croupier
    {
        public Croupier (Player player)
        {
            Player = player;
        }

        private Desk Desk { get; set; } = new Desk ();

        public Player Player { get; set; }

        public void GiveCardsToPlayer(short cardCount)
        {
            var cards = Desk.GetCardsFromDesc(cardCount);
            Player.SetCardsToPlayer(cards);
        }
    }
}

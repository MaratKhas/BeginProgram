using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    public class Player
    {
        private List<Card> _cards;

        public void SetCardsToPlayer(List<Card> cards)
        {
            _cards = cards;
        }

        public string GetCardsInfo()
        {
            var stringBuilder = new StringBuilder();

            foreach (var card in _cards)
            {
                stringBuilder.AppendLine(card.GetFullName());
            }

            return stringBuilder.ToString();
        }
    }
}

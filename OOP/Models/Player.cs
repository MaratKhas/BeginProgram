using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    public class Player
    {
        private List<Card> Cards;

        public void SetCardsToPlayer(List<Card> cards)
        {
            Cards = cards;
        }

        public string GetCardsInfo()
        {
            var stringBuilder = new StringBuilder();

            foreach (var card in Cards)
            {
                stringBuilder.AppendLine(card.GetFullName());
            }

            return stringBuilder.ToString();
        }
    }
}

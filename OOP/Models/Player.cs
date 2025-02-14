using OOP.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    public class Player  : IPlayer
    {
        private IEnumerable<ICard> _cards;

        public void SetCardsToPlayer(ICollection<ICard> cards)
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

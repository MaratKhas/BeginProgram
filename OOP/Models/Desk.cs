using System;
using System.Collections.Generic;
using System.Linq;
using OOP.Enums;
using OOP.Interfaces;

namespace OOP.Models
{
    public class Desk : IDesk
    {
        public Desk()
        {
            Cards = InitCards();
        }

        public IReadOnlyList<ICard> Cards { get; set; }

        private List<ICard> InitCards()
        {
            var cards = new List<ICard>(52);

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (int i = 2; i <= 10; i++)
                {
                    cards.Add(new Card { Id = cards.Count + 1, Name = i.ToString(), Suit = suit });
                }

                cards.Add(new Card { Id = cards.Count + 1, Name = "Валет", Suit = suit });
                cards.Add(new Card { Id = cards.Count + 1, Name = "Дама", Suit = suit });
                cards.Add(new Card { Id = cards.Count + 1, Name = "Король", Suit = suit });
                cards.Add(new Card { Id = cards.Count + 1, Name = "Туз", Suit = suit });
            }

            cards.Add(new Card { Id = cards.Count + 1, Name = "Джокер", Suit = 0 });

            for (int i = 0; i < new Random().Next(4,10); i++)
            {
                ShuffleCards(ref cards);
            }
            return cards;
        }

        private void ShuffleCards(ref List<ICard> cards)
        {
            var left = cards.Take(cards.Count() / 2);
            var right = cards.Skip(cards.Count() / 2).Take(cards.Count() / 2);
            var result = left.ShuffleCards(right);

            cards = result.ToList();

        }
        public ICollection<ICard> GetCardsFromDesc(short count)
        {
            return Cards?.Take(count).ToList() ?? new List<ICard>();
        }
    }
}

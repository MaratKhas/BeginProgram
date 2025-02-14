using System;
using System.Collections.Generic;
using System.Linq;
using OOP.Enums;

namespace OOP.Models
{
    public class Desk
    {
        public Desk()
        {
            InitCards();
        }

        private List<Card> Cards { get; set; }

        public void InitCards()
        {
            var cards = new List<Card>(52);

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

            Cards = cards;

            for (int i = 0; i < new Random().Next(20, 22); i++)
            {
                ShuffleCards();
            }

        }

        private void ShuffleCards()
        {
            var left = Cards.Take(Cards.Count / 2);
            var right = Cards.Skip(Cards.Count / 2).Take(Cards.Count / 2);
            var result = left.ShuffleCards(right).ToList();
            
            Cards = result;
        }

        public List<Card> GetCardsFromDesc(short count)
        {
            return Cards?.Take(count).ToList() ?? new List<Card>();
        }
    }
}

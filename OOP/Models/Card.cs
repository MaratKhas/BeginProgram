using OOP.Enums;


namespace OOP.Models
{
    public class Card
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Suit Suit { get; set; }

        public string GetFullName() => string.Join(" - ", Name, GetSuitName(Suit));

        public string GetSuitName(Suit suit)
        {
            switch (suit)
            {
                case Suit.Bubi:
                    {
                        return "Буби";
                    }
                case Suit.Сrosses:
                    {
                        return "Крести";
                    }
                case Suit.Peaks:
                    {
                        return "Пики";
                    }
                case Suit.Worms:
                    {
                        return "Червы";
                    }
                default: return "";
            }
        }
    }

}

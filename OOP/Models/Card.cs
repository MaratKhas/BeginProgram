using OOP.Enums;


namespace OOP.Models
{
    public class Card
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Suit Suit { get; set; }

        public string GetFullName() => string.Join(" - ", Name, Suit.ToString());
    }
}

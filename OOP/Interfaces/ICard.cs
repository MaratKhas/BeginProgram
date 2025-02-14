using OOP.Enums;

namespace OOP.Interfaces
{
    public interface ICard
    {
        int Id { get; set; }

        string Name { get; set; }

        Suit Suit { get; set; }

        string GetFullName();
    }
}

using System.Collections.Generic;

namespace OOP.Interfaces
{
    public interface IDesk
    {
        IReadOnlyList<ICard> Cards { get; set; }

        ICollection<ICard> GetCardsFromDesc(short count);
    }
}

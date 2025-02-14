using System.Collections.Generic;

namespace OOP.Interfaces
{
    public interface IPlayer
    {
        void SetCardsToPlayer(ICollection<ICard> cards);

        string GetCardsInfo();
    }
}

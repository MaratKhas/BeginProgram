namespace OOP.Interfaces
{
    public interface IСroupier
    {
        IDesk Desk { get; }

        IPlayer Player { get; }

        void GiveCardsToPlayer(short cardCount);
    }
}

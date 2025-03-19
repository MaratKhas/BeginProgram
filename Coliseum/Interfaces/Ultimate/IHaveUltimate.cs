namespace Coliseum.Interfaces
{

    public interface IHaveUltimate
    {
        void UseUltimate();
    }

    public interface IHaveUltimate<T> : IHaveUltimate where T : IUltimate
    {
        T Ultimate { get; }
    }
}

namespace _09_StrategyDesignPattern
{
    public interface ISpecification<T>
    {
        bool isSatisfied(T item);
    }
}

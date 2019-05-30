using System.Collections.Generic;

namespace _09_StrategyDesignPattern
{
    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> monitors, ISpecification<T> specification);
    }
}

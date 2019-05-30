using System.Collections.Generic;
using System.Linq;

namespace _09_StrategyDesignPattern
{
    public class MonitorFilter : IFilter<ComputerMonitor>
    {
        public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification) =>
            monitors.Where(m => specification.isSatisfied(m)).ToList();
    }
}

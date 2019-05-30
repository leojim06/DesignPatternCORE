namespace _09_StrategyDesignPattern
{
    public class MonitorTypeSpecification : ISpecification<ComputerMonitor>
    {
        public readonly MonitorType _type;

        public MonitorTypeSpecification(MonitorType type)
        {
            _type = type;
        }

        public bool isSatisfied(ComputerMonitor item) => item.Type == _type;
    }
}

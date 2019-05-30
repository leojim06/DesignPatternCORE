namespace _09_StrategyDesignPattern
{
    public class ScreenSpecification : ISpecification<ComputerMonitor>
    {
        public readonly Screen _screen;

        public ScreenSpecification(Screen screen)
        {
            _screen = screen;
        }

        public bool isSatisfied(ComputerMonitor item) => item.Screen == _screen;
    }
}

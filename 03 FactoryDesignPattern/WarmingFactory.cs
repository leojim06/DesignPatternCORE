namespace _03_FactoryDesignPattern
{
    public class WarmingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) =>
            new Warming(temperature);
    }
}

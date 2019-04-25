namespace _03_FactoryDesignPattern
{
    public class CoolingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) =>
            new Cooling(temperature);
    }
}

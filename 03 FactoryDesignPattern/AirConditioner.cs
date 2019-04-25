using System;
using System.Collections.Generic;

namespace _03_FactoryDesignPattern
{
    public class AirConditioner
    {
        private readonly Dictionary<AirConditionerEnum.Actions, AirConditionerFactory> _factories;
        private AirConditioner()
        {
            _factories = new Dictionary<AirConditionerEnum.Actions, AirConditionerFactory>();

            foreach (AirConditionerEnum.Actions action in Enum.GetValues(typeof(AirConditionerEnum.Actions)))
            {
                AirConditionerFactory factory = (AirConditionerFactory)Activator.CreateInstance(Type.GetType("_03_FactoryDesignPattern." + Enum.GetName(typeof(AirConditionerEnum.Actions), action) + "Factory"));
                _factories.Add(action, factory);
            }

            // Realiza la misma acción que el foreach anterior
            // Si existen varias factorias, el siguiente código crece una linea por cada factoria
            //_factories = new Dictionary<AirConditionerEnum.Actions, AirConditionerFactory>
            //{
            //    {AirConditionerEnum.Actions.Cooling, new CoolingFactory() },
            //    {AirConditionerEnum.Actions.Warming, new WarmingFactory() }
            //};
        }

        public static AirConditioner InitializeFactories() =>
            new AirConditioner();

        public IAirConditioner ExectureCreation(AirConditionerEnum.Actions action, double temperature) =>
            _factories[action].Create(temperature);
    }
}

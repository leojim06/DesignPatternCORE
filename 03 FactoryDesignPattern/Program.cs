using System;

namespace _03_FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //var factory = new AirConditioner().ExectureCreation(AirConditionerEnum.Actions.Cooling, 22.5);
            //factory.Operate();

            AirConditioner
                .InitializeFactories()
                .ExectureCreation(AirConditionerEnum.Actions.Cooling, 22.5)
                .Operate();
        }
    }
}


namespace _04_SingletonDesignPattern
{
    interface ISingletonContainer
    {
        int GetPopulation(string name);
    }
}


namespace _04_SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = SingletonDataContainer.Instance;
            var db2 = SingletonDataContainer.Instance;
            var db3 = SingletonDataContainer.Instance;
            var db4 = SingletonDataContainer.Instance;

        }
    }
}


using System;
using System.Collections.Generic;
using System.IO;

namespace _04_SingletonDesignPattern
{
    public class SingletonDataContainer : ISingletonContainer
    {
        private Dictionary<string, int> _capitals = new Dictionary<string, int>();

        public SingletonDataContainer()
        {
            Console.WriteLine("Initializing sigleton object");

            var elements = File.ReadAllLines("capitals.txt");
            for (int i = 0; i < elements.Length; i += 2)
            {
                _capitals.Add(elements[i], int.Parse(elements[i + 1]));
            }
        }

        public int GetPopulation(string name)
        {
            return _capitals[name];
        }

        public static SingletonDataContainer Instance { get; } = new SingletonDataContainer();
    }
}



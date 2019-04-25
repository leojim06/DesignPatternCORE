using System;

namespace _04_SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = SingletonDataContainer.Instance;
            Console.WriteLine(db.GetPopulation("Bogota"));
        }
    }
}

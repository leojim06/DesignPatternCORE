using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace _05_AdapterDesignPattern
{
    public class JsonConverter
    {
        private IEnumerable<Manufacturer> _manofacturers;

        public JsonConverter(IEnumerable<Manufacturer> manufacturers)
        {
            _manofacturers = manufacturers;
        }

        public void ConvertToJson()
        {
            var jsonManufacturers = JsonConvert.SerializeObject(_manofacturers, Formatting.Indented);
            Console.WriteLine("\nPrinting JSON list\n");
            Console.WriteLine(jsonManufacturers);
        }
    }
}

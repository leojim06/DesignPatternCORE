using System;

namespace _05_AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new XmlConverter();
            document.GetXML();
        }
    }
}

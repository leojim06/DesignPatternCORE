﻿using System;
using System.Collections.Generic;

namespace _01_BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product {Name = "Monitor", Price = 200.50},
                new Product {Name = "Mouse", Price = 20.41},
                new Product {Name = "Keyboard", Price = 30.15}
            };

            ProductStockReportBuilder builder = new ProductStockReportBuilder(products);
            ProductStockReportDirector director = new ProductStockReportDirector(builder);
            director.BuildStockReport();

            var report = builder.GetReport();
            Console.WriteLine(report);
        }

    }
}

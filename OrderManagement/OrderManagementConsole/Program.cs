using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using OrderManagement.PizzaDecorator;

namespace OrderManagement
{


    public class Program
    {
        static void Main(string[] args)
        {
            var fileName = @"C:\Users\Mohamed\Documents\GitHub\test10052023\OrderManagement\OrderManagement\Csv\test1.csv";
            var csvPrinter = new CsvPrinter(fileName);
            var factory = new FactoryPizzaMethod();
           
            string order = csvPrinter.PrintOrders();
            Console.WriteLine(order);
            IPizza pizza = factory.GetPizza(order);

        }
    }
}

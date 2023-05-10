using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.Extensions.Hosting;
using OrderManagement.PizzaDecorator;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderManagement;
using OrderManagementConsole;

namespace OrderManagement
{


    public class Program
    {
        static void Main(string[] args)
        {
            var fileName = @"C:\Users\Mohamed\Documents\GitHub\test10052023\OrderManagement\OrderManagement\Csv\test1.csv";
            var csvPrinter = new CsvPrinter(fileName);
            var factory = new FactoryPizzaMethod();
            var host = Startup.CreateHostBuilder().Build();
            var dbManager = host.Services.GetService<DatabaseManager>();

            string order = csvPrinter.PrintOrders();
            Console.WriteLine(order);
            IPizza pizza = factory.GetPizza(order);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace OrderManagement
{
   

    public class CsvPrinter
    {
        private string fileName;
        private CsvConfiguration configuration;

        public CsvPrinter(string fileName)
        {
            this.fileName = fileName;
            this.configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
                HasHeaderRecord = false,
            };
        }

        public string PrintOrders()
        {
            var orders = new List<Order>();
            string orderA="";
            using (var fs = File.Open(this.fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var textReader = new StreamReader(fs, Encoding.UTF8))
                using (var csv = new CsvReader(textReader, this.configuration))
                {
                    orders = csv.GetRecords<Order>().ToList();
                }
            }

            foreach (var order in orders)
            {
                orderA=$"{order.BasePizza};{order.DoughPizza}; {order.Extra}";

            }return orderA;
        }
    }

    
}

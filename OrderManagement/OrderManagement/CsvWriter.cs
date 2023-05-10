using CsvHelper;
using System.Data.SqlClient;
using System.Globalization;
namespace OrderManagement
{
    public class CsvWriter
    {
        private readonly string connectionString;
        public CsvWriter(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void PrintFileCsv(int Id)
        {
            string ricevuta = " ";
            string namefile = " ";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query1 = $"SELECT [id], [PizzaDescription], [price] FROM [PizzaManagement].[dbo].[Orders] WHERE [Id] = '{Id}'";
                using (var command = new SqlCommand(query1, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader.GetInt32(0);
                            var PizzaDescription = reader.GetString(1);
                            var price = reader.GetString(2);
                            ricevuta = $"Ricevuta n." + id + ";" + PizzaDescription + ";" + price ;
                            namefile = $@"C:\Users\Mohamed\Documents\GitHub\test10052023\OrderManagement\OrderManagement\Csv\{id}.csv";
                        }
                    }
                }
            }
            using (var writer = new StreamWriter(namefile))
            using (var csv = new CsvHelper.CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(ricevuta);
            }

        }
    }
}

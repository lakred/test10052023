using CsvHelper;
using OrderManagement.PizzaDecorator;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Transactions;


namespace OrderManagement
{
    public class DatabaseManager
    {
        private readonly string connectionString;

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertOrder(IPizza pizza)
        {

            var query = "INSERT INTO [Order] (PizzaDescription, Price) " +
                                    "VALUES ( @PizzaDescription, @Price); " +
                                    "SELECT CAST(SCOPE_IDENTITY() AS INT);";
            var order = new Receipt
            {
                PizzaDescription = pizza.GetDescription(),
                Price = pizza.GetCost()
            };
          

            int id;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PizzaDescription", order.PizzaDescription);
                    command.Parameters.AddWithValue("@Price", order.Price);
                    id = (int)command.ExecuteScalar();
                    command.ExecuteNonQuery();
                }

                
            }

           
            var printCsv = new CsvWriter(connectionString);
            printCsv.PrintFileCsv(id);

        }
    }
}
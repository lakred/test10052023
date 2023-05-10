using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderManagement;

namespace OrderManagementConsole
{
    public class Startup
    {
        public static IHostBuilder CreateHostBuilder() =>
           Host.CreateDefaultBuilder()
          .ConfigureServices((hostContext, services) =>
          {
              string connectionString = hostContext.Configuration.GetConnectionString("DefaultConnection");
              services.AddSingleton(new DatabaseManager(connectionString));
              services.AddSingleton(new CsvWriter(connectionString));
             
             
          });


    }
}


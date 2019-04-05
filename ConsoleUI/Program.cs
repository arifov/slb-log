using System;
using Microsoft.Extensions.Configuration;
using SLB.Log;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Log configuration should be setup on client app side, so I left this here.
            // I don't like an idea to add Serilog packages to this project, but I see no other way at the moment.
            // Every so called sink (ColoredConsole, File, etc) is a standalone package, so configuration must be done here.
            // There is another aproach - a congig file. If we go with config file, then probably we can avoid issue above.

            /* we cannot configure Serilog inside client app cuz we are going to hide log provider from end users behind our wrapper 
            var cfg = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .MinimumLevel.Debug()
                .WriteTo.ColoredConsole(
                    LogEventLevel.Verbose,
                    "{NewLine}{Timestamp:HH:mm:ss} [{Level}] ({CorrelationToken}) {Message}{NewLine}{Exception}");
            */

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            using (ILogManager logger = new LogManager(configuration))
            {
                //Simple log entry
                logger.Debug("Hello World!");

                //Parameterized log entry
                var quota = 100;
                var user = new { FirstName = "John", LastName = "Walter" };
                logger.Write(LogLevel.Warning, "Disk quota {Quota} MB exceeded by {User}", quota, user);

                //Exception handling
                var myDataObject = new { Property1 = "Value1", Property2 = "Value2", Property3 = "Value3" };
                try
                {
                    int x = 0;
                    int y = 10 / x;
                }
                catch (Exception ex)
                {
                    logger.Fatal("Got an exception for {MyDataObject}", ex, myDataObject);
                }
            }

            Console.ReadKey();
        }
    }
}

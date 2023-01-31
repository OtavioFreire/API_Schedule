using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Threading.Tasks;

namespace API_Schedule
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var configuration = GetConfiguration();

            Log.Logger = CreateSerilogLogger(configuration);

            var webHost = CreateHostBuilder(configuration, args).Build();

            await webHost.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(IConfiguration configuration, string[] args) =>
         Host.CreateDefaultBuilder(args)
             .ConfigureWebHostDefaults(webBuilder =>
             {
                 webBuilder.UseStartup<Startup>();
                 webBuilder.UseConfiguration(configuration);
             })
            .ConfigureWebHost(config =>
            {
                var port = configuration.GetValue<string>("PortNumber");
                config.UseUrls($"http://*:{port}");
            })
            .UseSerilog()
            .UseWindowsService();

        private static ILogger CreateSerilogLogger(IConfiguration configuration)
        {
            return new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
        }

        private static IConfiguration GetConfiguration()
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var appSettings = $"appsettings{(!string.IsNullOrEmpty(environment) ? $".{environment}" : string.Empty)}.json";

            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile(appSettings, optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            var configuration = builder.Build();
            return configuration;
        }
    }
}

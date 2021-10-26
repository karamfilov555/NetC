using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetC.CLI;
using NetC.CLI.Contracts;
using NetC.CLI.ScreenView;
using NetC.CLI.ScreenView.Contracts;
using NetC.Services;
using NetC.Services.Contracts;
using NetC.Utils;
using NetC.Utils.Contracts;

namespace NetC
{
    class Program
    {
        static void Main()
        {
            var host = CreateHostBuilder().Build();
            host.Services.GetRequiredService<IEngine>().Run();
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddTransient<IEngine, Engine>();
                    services.AddTransient<INetCScreen, NetCScreen>();
                    services.AddTransient<IIncomeTaxService, IncomeTaxService>();
                    services.AddTransient<ISocialContributionService, SocialContributionService>();
                    services.AddTransient<INetSalaryService, NetSalaryService>();
                    services.AddTransient<IReader, Reader>();
                    services.AddTransient<IWriter, Writer>();
                    services.AddTransient<IValidator, Validator>();
                });
        }
    }
}

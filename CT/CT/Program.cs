using DataLayer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<EFDBContext>();
                DBInitializer.InitData(context);
            }
            host.Run();


        }

        //public static IHost MigrateDbContext<TContext>(this IHost host) where TContext : DbContext
        //{
        //    // Create a scope to get scoped services.
        //    using (var scope = host.Services.CreateScope())
        //    {
        //        var services = scope.ServiceProvider;
        //        var logger = services.GetRequiredService<ILogger<TContext>>();
        //        // get the service provider and db context.
        //        var context = services.GetService<TContext>();

        //        // do something you can customize.
        //        // For example, I will migrate the database.
        //        context.Database.Migrate();
        //    }

        //    return host;
        //}

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

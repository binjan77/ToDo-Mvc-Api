using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ToDo_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Binjan; v1.9.1.0; 201/10/04; this line is newly added to solve issue to download images
            // e.g. http://www.rightmove.co.uk/overseas-property/find/Beverywherecom/UK.html?locationIdentifier=BRANCH%5E88684
            ServicePointManager.SecurityProtocol =                                          SecurityProtocolType.Tls13;

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

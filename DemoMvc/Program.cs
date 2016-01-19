using System.IO;
using Microsoft.AspNet.Hosting;

namespace DemoMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = WebHostConfiguration.GetDefault(args);

            var application = new WebHostBuilder()
                        .UseServer("Microsoft.AspNet.Server.Kestrel")
                        .UseApplicationBasePath(Directory.GetCurrentDirectory())
                        .UseConfiguration(configuration)
                        .UseStartup<Startup>()
                        .Build();

            application.Run();
        }
    }
}
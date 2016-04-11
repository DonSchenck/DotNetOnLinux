using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace HelloWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                        .UseKestrel()
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        .UseDefaultHostingConfiguration(args)
                        .UseIISIntegration()
                        .UseStartup<Startup>().UseUrls("http://*:5000")
                        .Build();

            host.Run();
        }
    }
}

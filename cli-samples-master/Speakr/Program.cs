using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

using Speakr.Models;

namespace Speakr
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Make sure the Database exists
            using (var db = new SubmissionContext())
            {
                db.Database.EnsureCreated();
            };

            // Build the self-hosting
            var host = new WebHostBuilder()
                        .UseKestrel()
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        .UseDefaultHostingConfiguration(args)
                        .UseIISIntegration()
                        .UseStartup<Startup>().UseUrls("http://*:5000")
                        .Build();

            // LAUNCH!
            host.Run();
        }
    }
}

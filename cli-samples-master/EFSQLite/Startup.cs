using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EFSQLite
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            loggerFactory.AddConsole(LogLevel.Debug);

            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            using (var db = new RequestHistoryContext())
            {
                db.Database.EnsureCreated();
            }

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
//            loggerFactory.AddConsole(LogLevel.Debug);

//            app.UseStaticFiles();

//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }

//            app.UseForwardedHeaders(new ForwardedHeadersOptions
//            {
//                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
//            });

//            app.UseMvc();

//            using (var db = new RequestHistoryContext())
//            {
//                db.Database.EnsureCreated();
//            }
//        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Nancy;
using Nancy.Owin;

    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // All dependency injection will be done in NancyBootstrapper
        }
        // This method gets called by the runtime.
        // We will configure this to use Nancy middleware.
        public void Configure(IApplicationBuilder app)
        {
            // Creating our request pipeline--strictly Nancy middleware
            app.UseOwin(x => x.UseNancy());
        }
    }

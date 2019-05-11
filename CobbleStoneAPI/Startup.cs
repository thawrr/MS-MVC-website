using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CobbleStoneAPI.Filters;
using CobbleStoneAPI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CobbleStoneAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {//the order of calls in the configure method does matter
            services
                .AddMvc(options =>
                {
                    options.Filters.Add<JsonExceptionFilter>();
                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //don't want to use pascal case
            services.AddRouting(options => options.LowercaseUrls = true);

            //dbConnection string!
            var connection = "Server=(localdb)\\MSSQLLocalDB;Database=CobbleStoneEmployeeDB;Trusted_Connection=True;";
            services.AddDbContext<CobbleStoneEmployeeDBContext>(options => options.UseSqlServer(connection));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {//sets up configuration pipeline
            //where to add middleware to respond to requests

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }

    }//end class
}//end namespace

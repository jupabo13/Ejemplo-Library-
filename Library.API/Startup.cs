using Contracts;
using Library.API.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            /* NLOG */
                LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config")); Configuration = configuration;
            /* End NLOG */
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /* Services ServiceExtensions */
                services.ConfigureCors();
                services.ConfigureIISIntegration();
                services.ConfigureLoggerService();
                services.ConfigureSqlContext(Configuration);
                services.ConfigureRepositoryManager();
            /* End Services ServiceExtensions */

            // Newton Soft. Serialización
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                   .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);


            /* AutoMapper */
            services.AddAutoMapper(typeof(Startup));

            /* Format XML */
            services.AddControllers(config => 
            { config.RespectBrowserAcceptHeader = true;
              config.ReturnHttpNotAcceptable = true;
            }).AddXmlDataContractSerializerFormatters();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Library.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerManager logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Library.API v1"));
            }

            /* ExectionMiddlewareExtensions */
                app.ConfigureExceptionHandler(logger);
            /* End ExectionMiddlewareExtensions */

            app.UseHttpsRedirection();

            /* Services ServiceExtensions */
                app.UseStaticFiles();
                app.UseCors("CorsPolicy");
                app.UseForwardedHeaders(new ForwardedHeadersOptions 
                { 
                    ForwardedHeaders = ForwardedHeaders.All
                });
            /* End Services ServiceExtensions */


            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

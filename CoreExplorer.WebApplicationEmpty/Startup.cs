using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace CoreExplorer.WebApplicationEmpty
{
    public class Startup
    {
        private IHostingEnvironment _env;
        private readonly Configuration conf;
        public Startup(IHostingEnvironment env)
        {
            this._env = env;
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json",true)
                .AddEnvironmentVariables()
                .Build();
            conf = new Configuration();
            builder.Bind(conf);
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            // Add application services.
            services.AddTransient<IClock,Clock>();

            services.AddSingleton(conf);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //if (false)//env.IsDevelopment()
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseStatusCodePagesWithRedirects("~/Errors/{0}.html");
            //}

            //app.UseStaticFiles();
            //app.UseFileServer();

            ///使用wwwroot下的静态默认页面
            //var options = new DefaultFilesOptions();
            //options.DefaultFileNames.Clear();
            //options.DefaultFileNames.Add("MyDefault.html");
            //app.UseDefaultFiles(options);
            //app.UseFileServer();

            
            app.Run(async (context) =>
            {
                if (context.Request.Form.ContainsKey("throw"))
                {
                    throw new Exception("Exception  triggered!");
                }
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}

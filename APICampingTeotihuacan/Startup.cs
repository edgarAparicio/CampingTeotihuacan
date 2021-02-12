using AutoMapper;
using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Context;
using EdgarAparicio.APICampingTeotihuacan.Manager.Interfaces;
using EdgarAparicio.APICampingTeotihuacan.Manager.Manager;
using EdgarAparicio.APICampingTeotihuacan.Repository.Interfaces;
using EdgarAparicio.APICampingTeotihuacan.Repository.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace APICampingTeotihuacan
{
    public class Startup
    {
        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DbContextAPICampingTeotihuacan>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<ICampRepository, CampRepostory>();
            services.AddScoped<ICampManager, CampManager>();
            services.AddMvc();
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());  //Solo para version .Net Core 2.2 y Map 5.0.1
            //services.AddAutoMapper(typeof(Startup));    |       //No funciona bien con .NEt Core 3.1 solo con ciertas cosas
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); //Configuracion correcta para cualquier version mapper con NEt.Core 3.1
            
            services.AddControllers();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

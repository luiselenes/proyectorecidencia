using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;

namespace ApiAlmacen
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
        {
            services.AddMediatR(typeof(Startup));
            services.AddControllers();

            services.AddDbContext<AlamacenDbContext>(ops =>
            ops.UseMySql(Configuration.GetConnectionString("conexion")));

           
            string assemblies = Configuration["Assembly:Function"];

            if (!string.IsNullOrEmpty(assemblies))
            {
                foreach (var item in assemblies.Split('|', StringSplitOptions.RemoveEmptyEntries))
                {
                    Assembly assembly = Assembly.Load(item);
                    foreach (var implement in assembly.GetTypes())
                    {
                        Type[] interfaceType = implement.GetInterfaces();
                        foreach (var service in interfaceType)
                        {
                            services.AddTransient(service, implement);
                        }
                    }
                }
            }
            services.AddDbContext<AlamacenDbContext>(ops => ops.UseMySql(Configuration.GetConnectionString("conexion")));
            
           




        }

        //  public void ConfigureServices(IServiceCollection services)
        // {
        //     //services.AddDbContext<StudentContext>(ops => ops.UseInMemoryDatabase("Students"));
        //     object p = services.AddDbContext<StudentContext>(ops => ops.UseMySql(@"Server=localhost; Database=Students; Uid=user_name_1; Pwd=my-secret-pw"));
        //     services.AddMvc();
        // }


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
            

          //  app.UseMvc();
        }
    }
}

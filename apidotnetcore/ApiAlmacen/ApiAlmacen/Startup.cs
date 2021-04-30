using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MediatR;

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

            /* var host = Configuration["DBHOST"] ?? "localhost";
             var port= Configuration["DBPORT"] ?? "3306";
            // var user = Configuration["DBUSER"] ?? "root";
             var password = Configuration["BDPASSWORD"] ?? "12345";
             //  var db = Configuration["BDNAME"] ?? "alamacen";

              services.AddDbContext<ApplicationDbContext>(option=> {
                  option.UseMySql($"server={host}; userid=root; pwd={password}: port={port}; database=alamacen");
              }*/

            var connectionString = config["mysqlconnection:connectionString"];
            services.AddDbContext<AlamacenDbContext>(o => o.UseMySql(connectionString));

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
            
            context.Database.Migrate();
            app.UseMvc();
        }
    }
}

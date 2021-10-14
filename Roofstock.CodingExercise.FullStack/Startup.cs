using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Roofstock.CodingExercise.FullStack.DataAccess;
using Roofstock.CodingExercise.FullStack.DataAccess.Repositories;
using Roofstock.CodingExercise.FullStack.Services;
using VueCliMiddleware;

namespace Roofstock.CodingExercise.FullStack
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
            services.AddControllers();
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp";
            });

            // Set up Entity Framework context
            services.AddDbContext<PropertyContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PropertyContext")));

            // Set up dependency injection
            services.AddTransient<IPropertyService, PropertyService>();
            services.AddTransient<IPropertyRepository, PropertyRepository>();

            // Set up AutoMapper to map between DTOs and DB entities
            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseSpaStaticFiles();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = env.IsDevelopment() 
                    ? "ClientApp/" 
                    : "dist";

                if (env.IsDevelopment())
                {
                    spa.UseVueCli(npmScript: "serve");
                }
            });
        }
    }
}

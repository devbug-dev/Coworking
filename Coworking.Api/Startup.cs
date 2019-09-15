using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using Coworking.DataContracts;
using Coworking.DataAccess;
using Coworking.CrossCutting.Register;
using Coworking.Api.Config;

namespace Coworking.Api
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
            services.AddTransient<ICoworkingDBContext, CoworkingDBContext>();
            services.AddDbContext<CoworkingDBContext>(o => o.UseSqlServer(Configuration.GetConnectionString("DB")));
            IoCRegister.Register(services);

            SwaggerConfig.Register(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //agregar servicios
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            SwaggerConfig.Register(app);
            app.UseEjemploMiddleware();
            app.UseHttpsRedirection();
            app.UseAuthentication();

            app.UseMvc();
        }
    }
}

using System;
using System.IO;
using Coworking.Api.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Coworking.Api.Config
{
    public static class SwaggerConfig
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            var basePath = System.AppDomain.CurrentDomain.BaseDirectory;
            var xmlPath = Path.Combine(basePath, "Coworking.Api.xml");

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Coworking Api", Version = "v1" });
                c.IncludeXmlComments(xmlPath);

                c.OperationFilter<AuthorizationHeaderParameterOperationFilter>();
            });

            return services;
        }

        public static IApplicationBuilder Register(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Coworking Api"));

            return app;
        }

    }
}
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace LotSystemAdmInfraCrossCutting.InversionOfControl
{
    public static class SwaggerDependency
    {
        public static void AddSwaggerDependency(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "LotSystem Administração API",
                        Version = "v1",
                        Description = "API REST created on ASP.NET Core 3.1",
                    });
            });
        }

        public static void UseSwaggerDependency(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "LotSystem Administração API");
                c.DocumentTitle = "LotSystem Administração API";
                c.DocExpansion(DocExpansion.List);
            });
        }
    }
}

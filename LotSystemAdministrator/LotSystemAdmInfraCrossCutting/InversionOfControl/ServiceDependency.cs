using LotSystemAdmDomain.Interfaces;
using LotSystemAdmService.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LotSystemAdmInfraCrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IPaisService, PaisService>();
        }
    }
}

using LotSystemAdmDomain.Interfaces;
using LotSystemAdmInfraData.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LotSystemAdmInfraCrossCutting.InversionOfControl
{
    public static class lRepositoryDependency
    {
        public static void AddRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IPaisRepository, PaisRepository>();
        }
    }
}

using Domain.AggregateModels.Borrowers;
using Domain.AggregateModels.ExternalLogins;
using Domain.BorrowerCards;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class InfrastructureDI
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IBorrowerRepository,BorrowerRepository>();
            services.AddScoped<IExternalLoginRepository, ExternalRepository>();
            services.AddScoped<IBorrowerCardRepository, BorrowerCardRepository>();
            return services;
        }
    }
}

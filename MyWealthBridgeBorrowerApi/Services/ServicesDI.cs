using MyWealthBridgeBorrowerApi.Services.BorrowerCardServices;
using MyWealthBridgeBorrowerApi.Services.BorrowerServices;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServicesDI
    {
        public static IServiceCollection AddServicesDI(this IServiceCollection services)
        {
            services.AddScoped<IBorrowerService, BorrowerService>();
            services.AddScoped<IBorrowerCardService, BorrowerCardService>();
            return services;
        }
    }
}

using ActivityTracker.Application;
using ActivityTracker.Infrastructure;
using ActivityTracker.Domain;

namespace ActivityTracker.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection service,IConfiguration configuration)
        {
            service.AddApplicationDI()
                .AddInfrastructureDI()
                .AddDomainDI(configuration);

            return service;
        }
    }
}

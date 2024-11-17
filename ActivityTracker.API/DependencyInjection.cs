using ActivityTracker.Application;
using ActivityTracker.Infrastructure;

namespace ActivityTracker.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection service)
        {
            service.AddApplicationDI()
                .AddInfrastructureDI();

            return service;
        }
    }
}

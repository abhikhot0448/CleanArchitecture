using Microsoft.Extensions.DependencyInjection;


namespace ActivityTracker.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection service)
        {
            return service;
        }
    }
}

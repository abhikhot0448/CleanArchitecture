using Microsoft.Extensions.DependencyInjection;

namespace ActivityTracker.Domain
{
    public static class DependencyInjection
    {
            public static IServiceCollection AddDomainDI(this IServiceCollection service)
            {
                return service;
            }
    }
}

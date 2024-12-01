using ActivityTracker.Domain.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ActivityTracker.Domain;

public static class DependencyInjection
{
        public static IServiceCollection AddDomainDI(this IServiceCollection service, IConfiguration configuration)
        {
            service.Configure<ConnectionStringOptions>(configuration.GetSection(ConnectionStringOptions.SectionName));

            return service;
        }
}

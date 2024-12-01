using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Options;
using ActivityTracker.Infrastructure.Data;
using ActivityTracker.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;


namespace ActivityTracker.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection service)
        {
            service.AddDbContext<ApplicationDbContext>((provider,options) => 
            {
                options.UseNpgsql(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>().Value.DefaultConnection);
            });

            service.AddScoped<IUserRepository, UserRepository>();

            return service;
        }
    }
}

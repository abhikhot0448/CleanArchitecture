using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Infrastructure.Data;
using ActivityTracker.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace ActivityTracker.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection service)
        {
            service.AddDbContext<ApplicationDbContext>(options => 
            {
                options.UseNpgsql("Host=localhost;Database=ActivityTracker;Username=postgres;Password=Abhi@0448");
            });

            service.AddScoped<IUserRepository, UserRepository>();

            return service;
        }
    }
}

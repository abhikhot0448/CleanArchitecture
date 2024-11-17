using ActivityTracker.Infrastructure.Data;
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

            return service;
        }
    }
}

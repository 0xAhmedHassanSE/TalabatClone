

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TalabatClone.Application.Interfaces.UnitOfWork;
using TalabatClone.Infrastructure.Database;
using TalabatClone.Infrastructure.Implementations.UnitOfWork;

namespace TalabatClone.Infrastructure.InfrastructureServices
{
    public static class InfraServices
    {
        public static IServiceCollection AddInfrastructure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TalabatDB>
                (option => option.UseSqlServer(configuration.GetConnectionString("Default")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}

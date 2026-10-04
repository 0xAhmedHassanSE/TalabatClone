

using Microsoft.Extensions.DependencyInjection;
using TalabatClone.Application.MappingProfiles;
using TalabatClone.Application.Services.Implementation;
using TalabatClone.Application.Services.InterFaces;

namespace TalabatClone.Application.ApplicationServices
{
    public static class AppServices
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(config => { }, typeof(RestaurantProfile));
            services.AddScoped<IRestaurantServices, RestaurantServices>();
            return services;
        }
    }
}

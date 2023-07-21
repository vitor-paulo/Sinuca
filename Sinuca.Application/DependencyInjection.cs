using Microsoft.Extensions.DependencyInjection;
using Sinuca.Application.Services;

namespace Sinuca.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<IMatchService, MatchService>();

            return services;
        }
    }
}

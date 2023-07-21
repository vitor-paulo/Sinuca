using Microsoft.Extensions.DependencyInjection;
using Sinuca.Application.Interfaces;
using Sinuca.Infrastructure.EnvironmentInformation;
using Sinuca.Infrastructure.Mongo;
using Sinuca.Infrastructure.Mongo.Repositories;

namespace Sinuca.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IEnvironmentVariables, EnvironmentVariables>();
            services.AddSingleton<IMongoContext, MongoContext>();
            services.AddSingleton<IPlayerRepository, PlayerRepository>();
            services.AddSingleton<IMatchRepository, MatchRepository>();

            return services;
        }
    }
}

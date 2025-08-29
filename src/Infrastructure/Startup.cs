using Application.Shared.CreateGame;
using Application.Shared.CreateHistory;
using Application.Shared.GetGames;
using Application.Shared.GetHistory;
using Domain;
using Domain.History;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class Startup
    {
        public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration) =>
        services
            .AddServices()
            .AddDatabase(configuration);

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IGetHistoryService, GetHistoryService>()
                    .AddScoped<ICreateGameService, CreateGameService>()
                    .AddScoped<IGetGamesService, GetGamesService>()
                    .AddScoped<ICreateHistoryService, CreateHistoryService>();

            return services;
        }

        private static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IHistoryRepository, HistoryRepository>();
            services.AddScoped<IGameRepository, GameRepository>();
            return services;
        }
    }
}

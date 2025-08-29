using Application.GetPlayHistory;
using Application.Shared.CreateGame;
using Application.Shared.CreateHistory;
using Application.Shared.GetGames;
using Application.Shared.GetHistory;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class Startup
    {
        public static IServiceCollection AddApplication(
        this IServiceCollection services) =>
        services
            .AddApplications();

        private static IServiceCollection AddApplications(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssembly(typeof(GetPlayHistoryQuery).Assembly));

            return services;
        }
    }
}

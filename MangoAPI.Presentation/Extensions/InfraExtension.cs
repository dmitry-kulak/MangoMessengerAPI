﻿using FluentValidation;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Pipelines;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Presentation.Extensions
{
    public static class InfraExtension
    {
        public static IServiceCollection AddAppInfrastructure(this IServiceCollection services)
        {
            services.AddPostgresDb();
            services.AddIdentityUsers();
            services.AddAppServices();
            services.AddAppAuthorization();
            services.AddAppAuthentication();
            services.AddValidatorsFromAssembly(typeof(LoginCommandValidator).Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            return services;
        }
    }
}

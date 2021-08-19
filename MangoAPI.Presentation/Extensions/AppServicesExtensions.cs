﻿namespace MangoAPI.Presentation.Extensions
{
    using MangoAPI.Application.Interfaces;
    using MangoAPI.Application.Services;
    using MangoAPI.BusinessLogic.ApiCommands.Users;
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;

    public static class AppServicesExtensions
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(RegisterCommandHandler).Assembly);
            services.AddScoped<IJwtGenerator, JwtGenerator>();
            services.AddScoped<IEmailSenderService, EmailSenderService>();
            return services;
        }
    }
}

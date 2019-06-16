using GOL.Application;
using GOL.Application.IApplication;
using GOL.DataAcess;
using GOL.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOL.CrossCutting
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection RegisterDependencys(this IServiceCollection services)
        {
            services.AddScoped<IAirplaneApplication, AirplaneApplication>();
            services.AddScoped<IAirplaneRepository, AirplaneRepository>();

            return services;
        }
    }
}

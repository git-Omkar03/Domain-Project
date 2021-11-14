using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extensions
{
    public static class ApllicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services , IConfiguration config)
        {
            services.AddScoped<ITokenServices, TokenService>();

            services.AddDbContextPool<DataContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DatabaseConnection"));
            });

            return services;
        }

        
    }
}

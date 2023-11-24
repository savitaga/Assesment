using EmployeeManagement.Infrastructure.Interfaces;
using EmployeeManagement.Infrastructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Extension
{
    public static class ServiceExtension
    {
        public static IServiceCollection SetupInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);
            services.AddScoped<IRepository,SqlRepository>();
            return services;
        }
    }
}

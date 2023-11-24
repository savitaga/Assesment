using EmployeeManagement.Core.Interfaces;
using EmployeeManagement.Core.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Extension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddSingleton(configuration);
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}

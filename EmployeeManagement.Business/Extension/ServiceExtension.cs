
using AutoMapper;
using EmployeeManagement.Business.Config;
using EmployeeManagement.Business.Interfaces;
using EmployeeManagement.Business.Services;
using Microsoft.Extensions.DependencyInjection;


namespace EmployeeManagement.Business.Extension
{
    public static class ServiceExtension
    {
        public static IServiceCollection SetupBusinessService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapperConfig));
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}

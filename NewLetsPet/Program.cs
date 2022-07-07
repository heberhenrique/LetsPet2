using Microsoft.Extensions.DependencyInjection;
using NewLetsPet.Domain.Employees;
using NewLetsPet.Domain.Security;
using NewLetsPet.ProgramFlows;
using NewLetsPet.ProgramFlows.Interfaces;
using NewLetsPet.Repositories;
using NewLetsPet.Repositories.Base;
using NewLetsPet.Repositories.Interfaces;
using NewLetsPet.Repositories.Interfaces.Base;
using NewLetsPet.Services;
using NewLetsPet.Services.Interfaces;

namespace NewLetsPet
{
    public class Program
    {
        /// <summary>
        /// Responsible for execute application.
        /// </summary>
        public static void Main()
        {
            ServiceCollection services = new();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            var mainFlow = serviceProvider.GetService<IMainFlow>();

            mainFlow.BeginApp();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IMainFlow, MainFlow>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IUserService, UserService>()
                .AddScoped<IStockFlow, StockFlow>()
                .AddScoped<IEmployeesFlow, EmployeesFlow>()
                .AddScoped<IEmployeeService, EmployeeService>()
                .AddScoped<IEmployeeRepository, EmployeeRepository>()
                .AddScoped<IBaseRepository<User>, BaseRepository<User>>()
                .AddScoped<IBaseRepository<Employee>, BaseRepository<Employee>>();
        }
    }
}


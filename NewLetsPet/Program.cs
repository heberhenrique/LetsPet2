using Microsoft.Extensions.DependencyInjection;
using NewLetsPet.Domain.Employees;
using NewLetsPet.Domain.Pets;
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
            // container
            services
                .AddScoped<IMainFlow, MainFlow>()
                .AddScoped<IStockFlow, StockFlow>()
                .AddScoped<IPetsFlow, PetsFlow>()
                .AddScoped<IEmployeesFlow, EmployeesFlow>()
                .AddScoped<IAttendanceFlow, AttendanceFlow>()
                .AddScoped<IUserService, UserService>()
                .AddScoped<IEmployeeService, EmployeeService>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IGuardianService, GuardianService>()
                .AddScoped<IGuardianRepository, GuardianRepository>()
                .AddScoped<IEmployeeRepository, EmployeeRepository>()
                .AddScoped<IBaseRepository<User>, BaseRepository<User>>()
                .AddScoped<IBaseRepository<Guardian>, BaseRepository<Guardian>>()
                .AddScoped<IBaseRepository<Employee>, BaseRepository<Employee>>();
        }
    }
}


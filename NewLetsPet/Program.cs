using Microsoft.Extensions.DependencyInjection;
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

            var userService = serviceProvider.GetService<IUserService>();
            mainFlow.BeginApp(userService);
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IMainFlow, MainFlow>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IUserService, UserService>()
                .AddScoped<IBaseRepository<User>, BaseRepository<User>>();
        }
    }
}


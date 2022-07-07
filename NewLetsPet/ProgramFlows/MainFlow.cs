using System;
using NewLetsPet.Domain.Security;
using NewLetsPet.Infrastructure;
using NewLetsPet.Presentations.Screens.Login;
using NewLetsPet.ProgramFlows.Interfaces;
using NewLetsPet.Repositories;
using NewLetsPet.Services;
using NewLetsPet.Services.Interfaces;

namespace NewLetsPet.ProgramFlows
{
	/// <summary>
    /// Represents the main application's flow.
    /// Responsible for configure all aplication paths to areas 
    /// </summary>
	public class MainFlow : IMainFlow
    {
        private readonly IUserService _service;

        public MainFlow(IUserService userService)
        {
            _service = userService;
        }

		public void BeginApp()
		{
            Console.WriteLine("Olá Mundo!");
            Console.WriteLine(_service.Mensagem());
        }
	}
}


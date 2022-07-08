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
        private readonly IStockFlow _stockFlow;
        private readonly IEmployeesFlow _employeesFlow;
        private readonly IAttendanceFlow _attendanceFlow;
        private readonly IPetsFlow _petsFlow;

        public MainFlow(
            IUserService userService,
            IStockFlow stockFlow,
            IEmployeesFlow employeesFlow,
            IAttendanceFlow attendanceFlow,
            IPetsFlow petsFlow)
        {
            _service = userService;
            _stockFlow = stockFlow;
            _employeesFlow = employeesFlow;
            _attendanceFlow = attendanceFlow;
            _petsFlow = petsFlow;
        }

        public void BeginApp()
		{
            //_stockFlow.NavigateStockMenu();
            //_employeesFlow.NavigateMenu();
            //_attendanceFlow.NavigateMenu();
            _petsFlow.Navigate();
        }
	}
}


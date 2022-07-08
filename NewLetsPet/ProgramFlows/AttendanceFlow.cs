using System;
using NewLetsPet.Domain.Extensions;
using NewLetsPet.Domain.Pets;
using NewLetsPet.Infrastructure;
using NewLetsPet.Presentations.Screens.Attendance;
using NewLetsPet.ProgramFlows.Interfaces;
using NewLetsPet.Services.Interfaces;

namespace NewLetsPet.ProgramFlows
{
	public class AttendanceFlow : IAttendanceFlow
    {
        private readonly IGuardianService _guardianService;

        public AttendanceFlow(IGuardianService guardianService)
		{
            _guardianService = guardianService;
        }

		public void NavigateMenu()
		{
            var selectedMenu = ScreenPresenter.GetOption(
                AttendanceMenu.MainMenu, 1, 4);

            switch (selectedMenu)
            {
                case 1:
                    CreateSchedule();
                    break;
                case 2:
                    //PrintStock();
                    break;
                case 3:
                    //OpenProduct();
                    break;
                case 4:
                    //ReportMainMenu();
                    break;
            }
        }

        private void CreateSchedule()
        {
            var cpfGuardian = ScreenPresenter.GetInput(
                RegisterSchedule.CpfGuardian, ValidateGuardian, RegisterSchedule.CpfGuardianInvalid);

        }

        public bool ValidateGuardian(string cpf)
        {
            return (cpf.ValidateCpf() && GetGuardian(cpf) != null);
        }

        public Guardian GetGuardian(string cpf)
        {
            return _guardianService.GetGuardianByCpf(cpf);
        }
    }
}


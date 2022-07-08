using System;
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
            return (ValidateCpf(cpf) && GetGuardian(cpf) != null);
        }

        public Guardian GetGuardian(string cpf)
        {
            return _guardianService.GetGuardianByCpf(cpf);
        }

        public bool ValidateCpf(string cpf)
        {
            string valor = cpf.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
            {
                return false;
            }

            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)

                if (valor[i] != valor[0])

                    igual = false;


            if (igual || valor == "12345678909")

                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)

                numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;

            for (int i = 0; i < 9; i++)

                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)

            {
                if (numeros[9] != 0)

                    return false;
            }

            else if (numeros[9] != 11 - resultado)
                return false;
            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)

            {
                if (numeros[10] != 0)

                    return false;
            }

            else

                if (numeros[10] != 11 - resultado)
            {
                return false;
            }
            return true;
        }
    }
}


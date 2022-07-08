using System;
using NewLetsPet.Domain.Pets;
using NewLetsPet.Infrastructure;
using NewLetsPet.Presentations.Screens.Pets;
using NewLetsPet.ProgramFlows.Interfaces;
using NewLetsPet.Services.Interfaces;

namespace NewLetsPet.ProgramFlows
{
	public class PetsFlow : IPetsFlow
    {
        private readonly IGuardianService _guardianService;

        public PetsFlow(IGuardianService guardianService)
        {
            _guardianService = guardianService;
        }

        public void Navigate()
        {
            var selectedMenu = ScreenPresenter.GetOption(
                MenuPets.MenuPet, 1, 5);

            switch (selectedMenu)
            {
                case 1:
                    RegisterGuardian();
                    break;
                case 2:
                    //ServicesMain.DefaultMenu();
                    break;
                case 3:
                    //MenuEmployee.DefaultMenu();
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }

        public void RegisterGuardian()
        {
            Guardian guardian = new Guardian();

            guardian.Cpf = ScreenPresenter.GetCpf(
                GuardianRegister.GuardianCpf, ValidateGuardian, GuardianRegister.GuardianAlreadyRegistered);

            guardian.Name = ScreenPresenter.GetInput(
                GuardianRegister.GuardianName, ValidateName, GuardianRegister.GuardianNameInvalid);

            _guardianService.CreateGuardian(guardian);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool ValidateGuardian(string obj)
        {
            //return !GuardianExists(obj);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        private Guardian GetGuardianByCpf(string cpf)
        {
            return _guardianService.GetGuardianByCpf(cpf);
        }

        private bool GuardianExists(string cpf)
        {
            return GetGuardianByCpf(cpf) != null;
        }

        private bool ValidateName(string obj)
        {
            return !string.IsNullOrWhiteSpace(obj);
        }
    }
}


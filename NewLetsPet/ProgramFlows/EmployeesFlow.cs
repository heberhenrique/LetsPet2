using System;
using NewLetsPet.Domain.Employees;
using NewLetsPet.Infrastructure;
using NewLetsPet.Presentations.Screens.Employees;
using NewLetsPet.ProgramFlows.Interfaces;
using NewLetsPet.Services.Interfaces;

namespace NewLetsPet.ProgramFlows
{
	public class EmployeesFlow : IEmployeesFlow
    {
        private readonly IEmployeeService _service;

        public EmployeesFlow(IEmployeeService service)
		{
            _service = service;
        }

        public void NavigateMenu()
        {
            var selectedMenu = ScreenPresenter.GetOption(
                EmployeeMenu.EmployeesMenu, 1, 4);

            switch (selectedMenu)
            {
                case 1:
                    RegisterNewEmployee();
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

        /// <summary>
        /// Responsible for get employee data from GUI
        /// </summary>
        private void RegisterNewEmployee()
        {
            Employee newEmployee = new Employee();

            newEmployee.Name = ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeName,
                ValidateEmployeeName,
                RegisterEmployeeScreen.EmployeeNameError);

            newEmployee.Cpf = ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeCPF,
                ValidateEmployeeCpf,
                RegisterEmployeeScreen.EmployeeCPFError);

            //newEmployee.BirthDate = ScreenPresenter.GetInput(
            //    RegisterEmployeeScreen.EmployeeBirthDate,
            //    ValidateEmployeeBirthDate,
            //    RegisterEmployeeScreen.EmployeeBirthDateError);

            newEmployee.BankData.Bank = ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeBankCode,
                ValidadeEmployeeBankCode,
                RegisterEmployeeScreen.EmployeeBankCodeError);

            newEmployee.BankData.Agency = ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeAgencyNumber,
                ValidateEmployeeAgencyNumber,
                RegisterEmployeeScreen.EmployeeAccountNumberError);

            newEmployee.BankData.AccountNumber = ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeAccountNumber,
                ValidateEmployeeAccountNumber,
                RegisterEmployeeScreen.EmployeeAccountNumberError);



            _service.CreateEmployee(newEmployee);
        }

        public bool ValidateEmployeeName(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }

        public bool ValidateEmployeeCpf(string cpf)
        {
            return !string.IsNullOrWhiteSpace(cpf);
        }

        //public bool ValidateEmployeeBirthDate(string birthDate)
        //{
        //  var Date = DateTime.Parse(birthDate);
        //    return true;
        //}

        public bool ValidadeEmployeeBankCode(string bankCode)
        {
            return !string.IsNullOrWhiteSpace(bankCode);
        }

        public bool ValidateEmployeeAgencyNumber(string agencyNumber)
        {
            return !string.IsNullOrWhiteSpace(agencyNumber);
        }

        public bool ValidateEmployeeAccountNumber(string accountNumber)
        {
            return !string.IsNullOrWhiteSpace(accountNumber);
        }

    }
}


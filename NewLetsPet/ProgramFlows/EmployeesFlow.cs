using NewLetsPet.Domain.Common.Enums;
using NewLetsPet.Domain.Employees;
using NewLetsPet.Infrastructure;
using NewLetsPet.Presentations.Screens.Employees;
using NewLetsPet.ProgramFlows.Interfaces;
using NewLetsPet.Services.Interfaces;
using System.Text.RegularExpressions;

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
                    //SearchEmployee();
                    break;
                case 3:
                    //Quit();
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
                ValidateString,
                RegisterEmployeeScreen.EmployeeNameError);

            newEmployee.Cpf = ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeCPF,
                ValidateEmployeeCpf,
                RegisterEmployeeScreen.EmployeeCPFError);

            newEmployee.BirthDate = Convert.ToDateTime(ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeBirthDate,
                ValidateEmployeeBirthDate,
                RegisterEmployeeScreen.EmployeeBirthDateError));

            newEmployee.PersonContact.Street = ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeContactStreet,
                ValidateString,
                RegisterEmployeeScreen.EmployeeContactStreetError);

            newEmployee.PersonContact.Number = Convert.ToInt32(ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeContactStreetNumber,
                ValidateNumber,
                RegisterEmployeeScreen.EmployeeContactStreetNumberError));

            newEmployee.PersonContact.AdditionalAddressInfo = ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeContactAddInfo,
                ValidateAddInfo);

            newEmployee.PersonContact.District = ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeContactDistrict,
                ValidateString,
                RegisterEmployeeScreen.EmployeeContactDistrictError);

            newEmployee.PersonContact.City = ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeContactCity,
                ValidateString,
                RegisterEmployeeScreen.EmployeeContactCityError);

            newEmployee.PersonContact.State = ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeContactState,
                ValidateString,
                RegisterEmployeeScreen.EmployeeContactStateError);

            newEmployee.PersonContact.ZipCode = ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeContactZipcode,
                ValidateZipCode,
                RegisterEmployeeScreen.EmployeeContactZipcodeError);

            newEmployee.PersonContact.MobileNumber = ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeContactMobileNumber,
                ValidateEmployeePhone,
                RegisterEmployeeScreen.EmployeeContactMobileNumberError);

            newEmployee.PersonContact.Email = ScreenPresenter.GetInput(
               RegisterEmployeeScreen.EmployeeContactEmail,
               ValidateEmployeeEmail,
               RegisterEmployeeScreen.EmployeeContactEmailError);


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

            PixMenu();

            decimal salary = Convert.ToDecimal(ScreenPresenter.GetInput(
                RegisterEmployeeScreen.EmployeeSalary,
                ValidateEmployeeSalary,
                RegisterEmployeeScreen.EmployeeSalaryError));

            newEmployee.UpdateSalary(salary);


            int employeeServicesInput = ScreenPresenter.GetOption(
                RegisterEmployeeScreen.EmployeeServiceTypes, 1, 3);

            newEmployee.ServicesType.Types = ConvertToServicesTypes(employeeServicesInput);

            void PixMenu()
            {
                var pixKeyMenu = ScreenPresenter.GetOption(
                   RegisterEmployeeScreen.EmployeePixKey, 1, 4);

                switch (pixKeyMenu)
                {
                    case 1:
                        newEmployee.BankData.Pix = ScreenPresenter.GetInput(
                            RegisterEmployeeScreen.EmployeePixCpf,
                            ValidateEmployeeCpf,
                            RegisterEmployeeScreen.EmployeeCPFError);
                        newEmployee.BankData.PixType = "Cpf";
                        break;
                    case 2:
                        newEmployee.BankData.Pix = ScreenPresenter.GetInput(
                             RegisterEmployeeScreen.EmployeePixEmail,
                             ValidateEmployeeEmail,
                             RegisterEmployeeScreen.EmployeeContactEmailError);
                        newEmployee.BankData.PixType = "Email";
                        break;
                    case 3:
                        newEmployee.BankData.Pix = ScreenPresenter.GetInput(
                            RegisterEmployeeScreen.EmployeePixPhone,
                            ValidateEmployeePhone,
                            RegisterEmployeeScreen.EmployeeContactPhoneError);
                        newEmployee.BankData.PixType = "Phone";
                        break;
                    case 4:
                        newEmployee.BankData.Pix = ScreenPresenter.GetInput(
                            RegisterEmployeeScreen.EmployeePixRandom,
                            ValidateEmployeeRandomKey,
                            RegisterEmployeeScreen.EmployeePixRandomError);
                        newEmployee.BankData.PixType = "RandomKey";
                        break;
                }
            }

            _service.CreateEmployee(newEmployee);
        }


        public bool ValidateString(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }

        public bool ValidateNumber(string number)
        {
            return int.TryParse(number, out _);
        }

        public bool ValidateEmployeeCpf(string cpf)
        {
            Regex RgxCpf = new(@"^\d{3}\.?\d{3}\.?\d{3}-?\d{2}$");
            return RgxCpf.Match(cpf).Success;
        }

        public bool ValidateEmployeeEmail(string email)
        {
            Regex RgxEmail = new(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return RgxEmail.Match(email).Success;
        }

        public bool ValidateEmployeeBirthDate(string birthDate)
        {
            return DateTime.TryParse(birthDate, out _);
        }

        public bool ValidadeEmployeeBankCode(string bankCode)
        {
            Regex RgxBankCode = new(@"^\d{3}$");
            return RgxBankCode.Match(bankCode).Success;
        }

        public bool ValidateEmployeeAgencyNumber(string agencyNumber)
        {
            Regex RgxAgencyCode = new(@"^\d{4,5}$");
            return RgxAgencyCode.Match(agencyNumber).Success;
        }

        public bool ValidateEmployeeAccountNumber(string accountNumber)
        {
            Regex RgxAccount = new(@"^\d{4,8}-\d{1}$");
            return RgxAccount.Match(accountNumber).Success;
        }

        public bool ValidateEmployeePhone(string phone)
        {
            Regex RgxPhone = new(@"^\(?\d{2}\)?\d{4,5}-?\d{4}$");
            return RgxPhone.Match(phone).Success;
        }
        public bool ValidateEmployeeRandomKey(string randomKey)
        {
            Regex RgxRandKey = new(@"^(\w+${8})\-(\w+${4})\-(\w+${4})\-(\w+${4})\-(\w+${12})");
            return RgxRandKey.Match(randomKey).Success;
        }

        public bool ValidateAddInfo(string addInfo)
        {
            return true;
        }

        public bool ValidateZipCode(string zipCode)
        {
            Regex RgxZipCode = new(@"^\d{5}-\d{3}$");
            return RgxZipCode.Match(zipCode).Success;
        }

        public bool ValidateEmployeeSalary(string salary)
        {
            return decimal.TryParse(salary, out _);
        }

        public List<ServiceTypes> ConvertToServicesTypes(int serviceType)
        {
            if (serviceType == 1)
            {
                return new List<ServiceTypes> { ServiceTypes.Bath };
            }
            else if (serviceType == 2)
            {
                return new List<ServiceTypes> { ServiceTypes.Grooming };
            }

            return new List<ServiceTypes> { ServiceTypes.Bath, ServiceTypes.Grooming };

        }

    }
}


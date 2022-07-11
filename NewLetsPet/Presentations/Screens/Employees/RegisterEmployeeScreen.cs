using System;
namespace NewLetsPet.Presentations.Screens.Employees
{
    public static class RegisterEmployeeScreen
    {
        public const string EmployeeInputError = "Opção inválida, tente novamente.";



        public const string EmployeeName = "Digite o nome do funcionário: ";
        public const string EmployeeNameError = "Nome digitado está em branco";


        public const string EmployeeCPF = "Digite o CPF do funcionário: ";
        public const string EmployeeCPFError = "O CPF informado é inválido.";


        public const string EmployeeBirthDate = "Digite a data de nascimento do funcionário: ";
        public const string EmployeeBirthDateError = "Insira uma data de nascimento válida.";


        public const string EmployeeSalary = "Digite o salário do funcionário: ";
        public const string EmployeeSalaryError = "Valor do salario digitado invalido, tente novamente.";


        #region Contact

        public const string EmployeeContactStreet = "Informe o nome da rua/avenida: ";
        public const string EmployeeContactStreetError = "O nome da Rua/Avenia é inválido.";

        public const string EmployeeContactStreetNumber = "Informe o número: ";
        public const string EmployeeContactStreetNumber = "O numero informado é inválido.";

        public const string EmployeeContactDistrict = "Informe o nome do bairro:";
        public const string EmployeeContactDistrictError = "O nome do bairro é inválido.";

        public const string EmployeeContactCity = "Informe o nome da cidade: ";
        public const string EmployeeContactCityError = "O nome da cidade é inválido.";

        public const string EmployeeContactState = "Informe o nome do estado: ";
        public const string EmployeeContactStateError = "O nome do estado é inválido.";

        public const string EmployeeContactZipcode = "Informe o CEP: ";
        public const string EmployeeContactZipcodeError = "CEP inválido.";

        public const string EmployeeContactMobileNumber = "Informe o numero de telefone: ";
        public const string EmployeeContactMobileNumberError = "Número de telefone inválido.";

        public const string EmployeeContactEmail = "Informe o email: ";
        public const string EmployeeContactEmailError = "Endereço de email inválido.";

        public const string EmployeeContactPhoneExist = "Possuiu telefone fixo?";
        public const string EmployeeContactPhone = "Informe o numero de telefone fixo:";
        public const string EmployeeContactPhoneError = @"Telefone digitado inválido!
Digite no formato (12)1234-1234";

        public const string EmployeeContactAdInfoExist = "Alguma informação adicional?";
        public const string EmployeeContactAdInfo = "Descreva a observação: ";
        public const string EmployeeContactAdInfoError = "O campo de observação está em branco.";


        #endregion


        #region BankInfo

        public const string EmployeeBankCode = "Digite o código do banco: ";
        public const string EmployeeBankCodeError = "Código de banco inválido, tente novamente.";


        public const string EmployeeAgencyNumber = "Digite o número da agência: ";
        public const string EmployeeAgencyNumberError = "Agência inválida, tente novamente.";


        public const string EmployeeAccountNumber = "Digite o número da conta: ";
        public const string EmployeeAccountNumberError = "Número de conta inválido, tente novamente.";



        public const string EmployeePixKey = @"
Digite o tipo da chave pix que deseja usar:
1. CPF
2. Email
3. Número de celular
4. Chave aleatória";

        public const string EmployeePixCpf = "Digite o CPF da chave pix: ";
        public const string EmployeePixEmail = "Digite o email da chave pix: ";
        public const string EmployeePixPhone = "Digite o número de celular da chave pix: ";
        public const string EmployeePixRandom = "Digite a chave pix aleatória: ";

        #endregion


        #region Services

        public const string EmployeeServiceSpecies = @"
Digite a espécie de animal que o funcionário vai atender:
1. Cachorro
2. Gato
3. Ambos ";



        public const string EmployeeServiceTypes = @"
Digite o tipo de serviços que o funcionário executará:
1. Banho
2. Tosa
3. Ambos";



        public const string EmployeeServiceSizes = @"
Digite o porte de animal que o funcionário irá atender:
1. Pequeno porte
2. Grande porte 
3. Ambos ";



        public const string EmployeeServiceNeeds = @"
O funcionário consegue lidar com animais que precisam de necessidades especiais?
1. Sim
2. Não";



        public const string EmployeeServiceAgressive = @"
O funcionário consegue lidar com animais agressigos?
1. Sim
2. Não";

        #endregion


    }
}


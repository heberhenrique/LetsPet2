using System;
using NewLetsPet.Domain.Common.Enums;
using NewLetsPet.Domain.Services;
using NewLetsPet.Infrastructure;
using NewLetsPet.Presentations.Screens.Services;

namespace NewLetsPet.ProgramFlows
{
	public static class ServicesFlow
	{
        public static void NavigateServiceMenu()
        {
            var selectedMenu = ScreenPresenter.GetOption(MenuServices.ServicesMenu, 1, 5);

            switch (selectedMenu)
            {
                case 1:
                    NavigateRegisterMenu();
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

        public static void NavigateRegisterMenu()
        {
            var selectOption = ScreenPresenter.GetOption(MenuServices.ServicesMenu, 1, 2);

            switch (selectOption)
            {
                case 1:
                    //
                    break;
                case 2:
                    RegisterService();
                    break;
            }
        }

        public static void RegisterService()
        {
            Service service = new();
            service.Type = (ServiceTypes)ScreenPresenter.GetOption(RegisterServiceScreen.GetServiceTypes(), 1, 2);


            //View - Console App - Valida preenchimento do objeto
            //BLL - Business Logic Layer
            //DLL - Data Access Layer

            //ServicesLogic serviceLogic = new();
            //serviceLogic.AddService(service);
            //Busca todos os serviços com este nome;
            //List<Service> services = serviceLogic.GetServiceByName(service.Name);
            //if(services == null || services.Count = 0)
            //{
            //   //prosseguir com cadastro
            //}
            //else
            //{
            //   //mostra mensagem de erro
            //}


            //ServiceBLL 
        }
    }
}


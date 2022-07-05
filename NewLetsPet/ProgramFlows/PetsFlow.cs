using System;
using NewLetsPet.Infrastructure;
using NewLetsPet.Presentations.Screens.Pets;

namespace NewLetsPet.ProgramFlows
{
	public static class PetsFlow
	{
        private static List<string> _errorMessages = new List<string>();

        private static int SelectMenuOption()
		{
			var response = 0;
            var isValid = false;
            var messages = string.Empty;

            do
            {
                var screenResponse = ScreenPresenter.Show(MenuPets.MenuPet, messages);

                if (int.TryParse(screenResponse, out response))
                {
                    isValid = (response > 0 && response < 6);

                    if (!isValid)
                        messages = "Opção Inválida";
                }
                
            } while (!isValid);

			return response;
		}

        public static void Navigate()
        {
            var selectedMenu = SelectMenuOption();

            switch (selectedMenu)
            {
                case 1:
                    //Navigation.MenuPrincipal();
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
	}
}


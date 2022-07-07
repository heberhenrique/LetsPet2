using System;
using System.Text;
using NewLetsPet.Domain.Common.Enums;
using NewLetsPet.Infrastructure;
using NewLetsPet.Presentations.Screens.Stock;
using NewLetsPet.ProgramFlows.Interfaces;

namespace NewLetsPet.ProgramFlows
{
	public class StockFlow : IStockFlow
    {
		public StockFlow()
		{
		}

		public void NavigateStockMenu()
		{
            var selectedMenu = ScreenPresenter.GetOption(
                ComposeScreen(StockMenu.ProductMenu), 1, 4);

            switch (selectedMenu)
            {
                case 1:
                    RegisterNewProduct();
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

        private void RegisterNewProduct()
        {
            var selectedCategory = (Category)ScreenPresenter.GetOption(
                ComposeScreen(StockMenu.CategorySelectionMenu), 1, 3);



            //var selectedCategory = (Category)ScreenPresenter.GetOption(
            //    ComposeScreen(StockMenu.ProductMenu), 1, 3);

            //var selectedCategory = (Category)ScreenPresenter.GetOption(
            //    ComposeScreen(StockMenu.ProductMenu), 1, 3);
        }

        public string ComposeScreen(string screen, string subHeader = "")
        {
            StringBuilder sb = new();

            sb.AppendLine(StockMenu.HeaderStock);

            if(!string.IsNullOrWhiteSpace(subHeader))
                sb.AppendLine(subHeader);

            sb.AppendLine(screen);

            return sb.ToString();
        }
    }
}


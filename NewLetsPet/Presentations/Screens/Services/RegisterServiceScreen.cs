using System;
using System.Text;
using NewLetsPet.Domain.Common.Enums;

namespace NewLetsPet.Presentations.Screens.Services
{
	public static class RegisterServiceScreen
	{
        public static string GetServiceTypes()
        {
            StringBuilder sb = new();
            sb.AppendLine("O que você deseja cadastrar?");
            foreach (ServiceTypes service in Enum.GetValues(typeof(ServiceTypes)))
            {
                sb.AppendLine($"{((int)service)} - {service}");
            }

            return sb.ToString();
        }
    }
}


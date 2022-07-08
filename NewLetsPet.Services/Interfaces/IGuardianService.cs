using System;
using NewLetsPet.Domain.Pets;

namespace NewLetsPet.Services.Interfaces
{
	public interface IGuardianService
	{
		public Guardian GetGuardianByCpf(string cpf);
	}
}


using System;
using NewLetsPet.Domain.Pets;
using NewLetsPet.Repositories.Interfaces;
using NewLetsPet.Services.Interfaces;

namespace NewLetsPet.Services
{
	public class GuardianService : IGuardianService
    {
        private readonly IGuardianRepository _guardianRepository;

		public GuardianService(IGuardianRepository guardianRepository)
		{
            _guardianRepository = guardianRepository;
        }

        public Guardian CreateGuardian(Guardian guardian)
        {
            return _guardianRepository.SaveGuardian(guardian);
        }

        public Guardian GetGuardianByCpf(string cpf)
        {
            return new Guardian();
        }
    }
}


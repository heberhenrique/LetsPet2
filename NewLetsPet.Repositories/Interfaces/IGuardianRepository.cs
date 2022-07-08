using System;
using NewLetsPet.Domain.Pets;

namespace NewLetsPet.Repositories.Interfaces
{
	public interface IGuardianRepository
	{
        public Guardian SaveGuardian(Guardian guardian);
    }
}


using System;
using NewLetsPet.Domain.Pets;
using NewLetsPet.Repositories.Interfaces;
using NewLetsPet.Repositories.Interfaces.Base;

namespace NewLetsPet.Repositories
{
	public class GuardianRepository : IGuardianRepository
    {
        private readonly IBaseRepository<Guardian> _database;
        public List<Guardian> Guardians { get; }

        public GuardianRepository(IBaseRepository<Guardian> database)
		{
            _database = database;

            var values = _database.Get();
            if (values != null)
                Guardians = values.ToList();
            else
                Guardians = new();
        }

        public Guardian SaveGuardian(Guardian guardian)
        {
            guardian.Id = Guardians.Count + 1;
            Guardians.Add(guardian);
            _database.Save(Guardians);
            return guardian;
        }
    }
}


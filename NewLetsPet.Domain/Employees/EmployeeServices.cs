using System;
using NewLetsPet.Domain.Common.Enums;

namespace NewLetsPet.Domain.Employees
{
	public class EmployeeServices
	{
        public List<Species> Species { get; set; }
        public List<ServiceTypes> Types { get; set; }
        public List<BreedSize> Sizes { get; set; }
        public bool MeetsSpecialNeeds { get; set; }
        public bool MeetsAggressiveAnimal { get; set; }

        public EmployeeServices()
        {

        }

        public EmployeeServices(List<BreedSize> sizes, List<ServiceTypes> types, List<Species> species, bool meetsSpecialNeeds, bool meetsAggressiveAnimal)
        {
            Types = types;
            Species = species;
            Sizes = sizes;
            MeetsSpecialNeeds = meetsSpecialNeeds;
            MeetsAggressiveAnimal = meetsAggressiveAnimal;
        }
    }
}


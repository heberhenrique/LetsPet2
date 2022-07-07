using System;
using NewLetsPet.Domain.Common.Enums;

namespace NewLetsPet.Domain.Services
{
	public class Service
	{
        public ServiceTypes Type { get; set; }
        public Species Species { get; set; }
        public BreedSize Size { get; set; }
        public string Name { get; set; }
        public bool Special { get; set; }
        public bool Lotion { get; set; }
        public GroomingTypes GroomingType { get; set; }
        public int ServiceTime { get; set; } = 1;
        public int AmountEmployees { get; set; }
        public double Price { get; set; }

        public Service()
		{
		}
	}
}


using System;
using NewLetsPet.Domain.Common.Enums;

namespace NewLetsPet.Domain.Pets
{
	public class Animal
	{
        public Guardian Guardian { get; set; }
        public string Name { get; set; }
        public Species Species { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public BreedSize BreedSize { get; set; }
        public decimal Weight { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public int Age { get { return AgeCalculator(); } }
        public bool CastratedBool { get; set; }
        public bool DiseasesBool { get; set; }
        public bool AggressiveBool { get; set; }
        public bool AllergiesBool { get; set; }
        public bool PhysicalDisabilityBool { get; set; }
        public DateTime RegistrationDate { get { return DateTime.Now; } }

        public List<string> AllergiesList { get; set; }
        public List<string> DiseasesList { get; set; }
        public List<string> PhysicalDisabilityList { get; set; }
        public List<PetVaccine> PetVaccineList { get; set; }



        public Animal()
		{
		}

        public int AgeCalculator()
        {
            int idade = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
            {
                idade--;
            }
            return idade;
        }
    }
}


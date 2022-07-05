using NewLetsPet.Domain.Common.Enums;

namespace NewLetsPet.Domain.Pets
{
    public class VaccineType
    {
        public string VaccineName { get; set; }
        public Species VaccineSpecies { get; set; }
        public int VaccineValidity { get; set; }

        public static List<VaccineType> VaccineTypeList = new();

        public VaccineType()
        {

        }

        public VaccineType(string vaccineName, Species vaccineSpecies, int vaccineValidity)
        {
            VaccineName = vaccineName;
            VaccineSpecies = vaccineSpecies;
            VaccineValidity = vaccineValidity;
        }
    }
}
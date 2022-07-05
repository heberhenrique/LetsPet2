using NewLetsPet.Domain.Common;

namespace NewLetsPet.Domain.Pets
{
    public class Guardian : Person
    {
        public List<Animal> PetList { get; set; } = new List<Animal>();
    }
}
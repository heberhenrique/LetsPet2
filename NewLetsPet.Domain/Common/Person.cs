using System;
namespace NewLetsPet.Domain.Common
{
	public class Person
	{
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Contact PersonContact { get; set; }
        public DateTime RegisterDate { get; set; }

        public Person()
		{
		}
	}
}


using System;
using NewLetsPet.Domain.Employees;

namespace NewLetsPet.Repositories.Interfaces
{
	public interface IEmployeeRepository
	{
        public Employee SaveEmployee(Employee employee);

    }
}


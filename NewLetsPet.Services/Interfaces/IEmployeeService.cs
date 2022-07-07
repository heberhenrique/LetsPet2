using System;
using NewLetsPet.Domain.Employees;

namespace NewLetsPet.Services.Interfaces
{
	public interface IEmployeeService
	{
        public Employee CreateEmployee(Employee employee);

    }
}


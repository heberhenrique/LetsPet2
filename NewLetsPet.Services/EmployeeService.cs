using System;
using NewLetsPet.Domain.Employees;
using NewLetsPet.Repositories.Interfaces;
using NewLetsPet.Services.Interfaces;

namespace NewLetsPet.Services
{
	public class EmployeeService : IEmployeeService
    {
		private readonly IEmployeeRepository _repository;

		public EmployeeService(IEmployeeRepository repository)
		{
			_repository = repository;
		}

		public Employee CreateEmployee(Employee employee)
		{
			return _repository.SaveEmployee(employee);
		} 
	}
}


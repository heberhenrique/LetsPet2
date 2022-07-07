using System;
using NewLetsPet.Domain.Employees;
using NewLetsPet.Repositories.Interfaces;
using NewLetsPet.Repositories.Interfaces.Base;

namespace NewLetsPet.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IBaseRepository<Employee> _database;
        public List<Employee> Employees { get; }

        public EmployeeRepository(IBaseRepository<Employee> database)
		{
            _database = database;

            var values = _database.Get();
            if (values != null)
                Employees = values.ToList();
            else
                Employees = new();
        }

		public List<Employee> GetEmployees()
		{
			return new List<Employee>();
		}

		public Employee GetEmployeeByCpf(string cpf)
		{
			return new Employee();
		}

        public Employee GetEmployeeByName(string cpf)
        {
            return new Employee();
        }

        public Employee SaveEmployee(Employee employee)
        {
            employee.Id = Employees.Count + 1;
            Employees.Add(employee);
            _database.Save(Employees);
            return employee;
        }
    }
}


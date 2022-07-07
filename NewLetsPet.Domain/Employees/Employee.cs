﻿using System;
using NewLetsPet.Domain.Common;

namespace NewLetsPet.Domain.Employees
{
	public class Employee : Person
	{
        public BankInfo BankData { get; set; }
        public Dictionary<DateTime, decimal> Salaries { get; set; } = new Dictionary<DateTime, decimal>();
        public EmployeeServices ServicesType { get; set; }
        public bool ActiveEmployee { get; set; }
        public DateTime DismissalDate { get; set; }
        public DateTime[] Schedule { get; set; }

        public Employee()
        {

        }

        public Employee(string cpf, string name, Contact employeeContact, DateTime birthDate, BankInfo bankData,
            decimal salary, EmployeeServices servicesType, DateTime[] schedule)
        {
            Cpf = cpf;
            Name = name;
            BirthDate = birthDate;
            PersonContact = employeeContact;
            RegisterDate = DateTime.Now;
            BankData = bankData;
            ServicesType = servicesType;
            ActiveEmployee = true;
            Schedule = schedule;
            DismissalDate = DateTime.MinValue;
            DateTime effectiveDate = DateTime.Now;
            Salaries.Add(effectiveDate, salary);
        }

        public void UpdateDismissalDate(DateTime dismissalDate)
        {
            Console.WriteLine("Data de desligamento: ");
            DismissalDate = dismissalDate;
            UpdateStatus();
        }

        public void UpdateStatus()
        {
            if (DismissalDate != DateTime.MinValue)
            {
                ActiveEmployee = false;
            }
        }

        public void UpdateSalary(decimal salary)
        {
            Salaries.Add(DateTime.Now, salary);
        }

        public void UpdateSchedule(DateTime[] schedule)
        {
            Schedule = schedule;
        }

        public decimal GetSalary()
        {
            return Salaries.Values.Last();
        }
	}
}

